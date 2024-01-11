using System;

namespace Adapter
{
    internal class Payoneer : IPayoneerPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento via Payoneer.");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Envinado pagamentos via Payoneer.");
        }
    }
}

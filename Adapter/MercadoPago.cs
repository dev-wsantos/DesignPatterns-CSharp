using System;

namespace Adapter
{
    internal class MercadoPago : IMercadoPagoPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePaymentFromAPI()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos via API do Mercado Pago");
        }

        public void SendPaymentFromAPI()
        {
            token = AuthToken();
            Console.WriteLine("Enviado pagamentos via API do Mercado Pago");
          
        }
    }
}

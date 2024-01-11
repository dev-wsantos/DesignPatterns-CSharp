namespace Adapter
{
    internal class PayoneerAdapter : IPayPalPayment
    {
        private Payoneer payoneer;

        public PayoneerAdapter(Payoneer payoneer) 
        { 
            this.payoneer = payoneer;
        }
        public Token AuthToken()
        {
            return payoneer.AuthToken(); 
        }

        public void PayPalPayment()
        {
            payoneer.SendPayment();
        }

        public void PayPalReceive()
        {
            payoneer.ReceivePayment();
        }
    }
}

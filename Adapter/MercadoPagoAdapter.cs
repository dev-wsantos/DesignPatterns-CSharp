namespace Adapter
{
    internal class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago _mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return _mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            _mercadoPago.SendPaymentFromAPI();
        }

        public void PayPalReceive()
        {
            _mercadoPago.ReceivePaymentFromAPI();
        }
    }
}

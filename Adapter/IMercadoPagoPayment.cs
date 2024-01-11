namespace Adapter
{
    internal interface IMercadoPagoPayment
    {
        Token AuthToken();

        void SendPaymentFromAPI();

        void ReceivePaymentFromAPI();
    }
}

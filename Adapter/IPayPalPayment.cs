namespace Adapter
{
    internal interface IPayPalPayment
    {
        Token AuthToken();

        void PayPalPayment();
        void PayPalReceive();
    }
}

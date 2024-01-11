namespace Adapter
{
    internal interface IPayoneerPayment
    {
        Token AuthToken();

        void SendPayment();

        void ReceivePayment();

    }
}

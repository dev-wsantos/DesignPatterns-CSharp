using System;
namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();
            //Payoneer payment = new Payoneer();

            IPayPalPayment payment = new PayoneerAdapter(new Payoneer());

            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.WriteLine("------------------------------------------------------------");

            IPayPalPayment newPayment = new MercadoPagoAdapter(new MercadoPago());

            newPayment.PayPalPayment();
            newPayment.PayPalReceive();

            Console.ReadKey();
        }
    }
}

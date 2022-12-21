namespace Interfaces
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            // CreditCardPaymment pagoTarCredito = new CreditCardPaymment();
            // DebitCardPaymment pagoTarDebito = new DebitCardPaymment();
            // PaypalPayment pagoPaypal = new PaypalPayment();

            PaymentModeFactory.Create(Mode.CreditCard).MakePayment();
            PaymentModeFactory.Create(Mode.DebitCard).MakePayment();
            PaymentModeFactory.Create(Mode.PaypalPay).MakePayment();
            PaymentModeFactory.Create(Mode.Pse).MakePayment();

            // PaymentManager pagoAdmin = new PaymentManager(pagoTarCredito, pagoTarDebito, pagoPaypal);

            // pagoAdmin.ManagePayment();

        }
    }

}
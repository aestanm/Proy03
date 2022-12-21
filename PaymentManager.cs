namespace Interfaces
{
    public class PaymentManager
    {
        // private readonly CreditCardPaymment _creditCard;
        // private readonly DebitCardPaymment _debitCard;
        // private readonly PaypalPayment _paypalPay;
        private readonly IPaymentMode _paymentMode;

        // public PaymentManager(CreditCardPaymment creditCard, DebitCardPaymment debitCard, PaypalPayment paypalPay)
        // {
        //     _creditCard = creditCard;
        //     _debitCard = debitCard;
        //     _paypalPay = paypalPay;
        // }

        public  PaymentManager(IPaymentMode paymentMode){
            _paymentMode = paymentMode;
        }

        public void ManagePayment()
        {
            // _creditCard.MakePayment();
            // _debitCard.MakePayment();
            // _paypalPay.MakePayment();
            _paymentMode.MakePayment();
        }

    }
}
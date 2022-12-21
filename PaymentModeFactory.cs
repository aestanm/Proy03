using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//clase especializada en crear objetos de tipo pago
namespace Interfaces
{

    public enum Mode{
        CreditCard,
        DebitCard,
        PaypalPay,
        Pse
    }

    public class PaymentModeFactory
    {
        public static IPaymentMode Create(Mode mode){
            if(mode==Mode.CreditCard)
                return new CreditCardPaymment();
            else if (mode==Mode.DebitCard)
                return new DebitCardPaymment();
            else if(mode==Mode.Pse)
                return new PsePayment();
            else
                return new PaypalPayment();
        
        }
    }
}
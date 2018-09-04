using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class PaymentServiceA  : IPaymentService
    {
        IPaymentVerify paymentVerify;

        public PaymentServiceA(IPaymentVerify paymentVerify)
        {
            this.paymentVerify = paymentVerify;
        }

        public PaymentServiceA()
        {
            paymentVerify = new VerificationMethodA();
        }

        public void Pay(PaymentDetails details)
        {
            if (Verify(details))
            {
                //Call Payment Service
            }
        }

        public bool Verify(PaymentDetails details)
        {
            return paymentVerify.Verify(details);
        }
    }
}

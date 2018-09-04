using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class PaymentServiceB : IPaymentService
    {
        IPaymentVerify paymentVerify;

        public PaymentServiceB(IPaymentVerify paymentVerify)
        {
            this.paymentVerify = paymentVerify;
        }

        public PaymentServiceB()
        {
            paymentVerify = new VerificationMethodB();
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

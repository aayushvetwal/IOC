using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public interface IPaymentService
    {
        void Pay(PaymentDetails details);
        bool Verify(PaymentDetails details);
    }
}

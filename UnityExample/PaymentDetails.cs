using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class PaymentDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State{get; set;}
        public string ZipCode { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public DateTime Expiry { get; set; }
    }
}

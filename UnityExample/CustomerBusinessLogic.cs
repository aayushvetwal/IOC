using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _dataAccess;
        IPaymentService _paymentService;

        public CustomerBusinessLogic(ICustomerDataAccess dataAccess, IPaymentService paymentService)
        {
            _dataAccess = dataAccess;
            _paymentService = paymentService;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}

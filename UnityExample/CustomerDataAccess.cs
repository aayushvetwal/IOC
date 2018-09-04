﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return String.Format("Stage {0}: Dummy Customer Name", id);
        }
    }
}

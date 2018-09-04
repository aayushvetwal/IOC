using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stage 1
            Stage1.CustomerBusinessLogic customerBL1 = new Stage1.CustomerBusinessLogic();
            string customerName1 = customerBL1.GetCustomerName(1);
            Console.WriteLine(customerName1);

            //Stage 2
            Stage2.CustomerBusinessLogic customerBL2 = new Stage2.CustomerBusinessLogic();
            string customerName2 = customerBL2.GetCustomerName(2);
            Console.WriteLine(customerName2);

            //Stage 3
            Stage3.CustomerBusinessLogic customerBL3 = new Stage3.CustomerBusinessLogic();
            string customerName3 = customerBL3.GetCustomerName(3);
            Console.WriteLine(customerName3);

            //Stage 4
            Stage4.CustomerBusinessLogic customerBL4 = new Stage4.CustomerBusinessLogic(new Stage4.CustomerDataAccess());
            string customerName4 = customerBL4.GetCustomerName(4);
            Console.WriteLine(customerName4);

            //Stage 5
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Stage5.ICustomerDataAccess, Stage5.CustomerDataAccess>();
            Stage5.CustomerBusinessLogic customerBL5 = container.Resolve<Stage5.CustomerBusinessLogic>();
            string customerName5 = customerBL5.GetCustomerName(5);
            Console.WriteLine(customerName5);
        }
    }
}

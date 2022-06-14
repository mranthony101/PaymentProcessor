using PaymentExample.Enum;
using PaymentExample.Interfaces;
using PaymentExample.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProcessorType processorType = (ProcessorType)Convert.ToInt32(ConfigurationManager.AppSettings["ProcessorType"]);

            //IPaymentProcessor processor = Utility.GetPaymentProcessor(processorType);
            //processor.Initialize();
            //processor.ProcessPayment();

            Car c = new Car();
            Airplane a = new Airplane();

            c.Refuel();
            a.Refuel();

            a.TestMethod();
            c.TestMethod();

        }
    }
}

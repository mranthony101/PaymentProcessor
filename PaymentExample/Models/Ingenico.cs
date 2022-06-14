using PaymentExample.Enum;
using PaymentExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample.Models
{
    public class Ingenico : IPaymentProcessor
    {
        private ProcessorType _type;

        public Ingenico()
        {
            _type = ProcessorType.Ingenico;
        }

        public void Initialize()
        {
            Console.WriteLine($"Ingenico is initalized");
        }

        public void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}

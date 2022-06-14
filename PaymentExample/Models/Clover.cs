using PaymentExample.Enum;
using PaymentExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample.Models
{
    public class Clover : IPaymentProcessor
    {
        private ProcessorType _type;

        public Clover()
        {
            _type = ProcessorType.Clover;
        }

        public void Initialize()
        {
            Console.WriteLine($"Clover is initalized");
        }

        public void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}

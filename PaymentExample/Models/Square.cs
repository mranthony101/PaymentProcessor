using PaymentExample.Enum;
using PaymentExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample.Models
{
    public class Square : IPaymentProcessor
    {
        private ProcessorType _type;

        public Square()
        {
            _type = ProcessorType.Square;
        }

        public void Initialize()
        {
            Console.WriteLine($"Square is initalized");
        }

        public void ProcessPayment()
        {
            throw new NotImplementedException();
        }

        private void DoSquareThings()
        {

        }
    }
}

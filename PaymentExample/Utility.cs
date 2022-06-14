using PaymentExample.Enum;
using PaymentExample.Interfaces;
using PaymentExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample
{
    public static class Utility
    {
        public static IPaymentProcessor GetPaymentProcessor(ProcessorType type)
        {
            switch (type)
            {
                case ProcessorType.Clover:
                    return new Clover();
                case ProcessorType.Ingenico:
                    return new Ingenico();
                case ProcessorType.Square:
                    return new Square();
                default:
                    return null;
                
            }

        }
    }
}

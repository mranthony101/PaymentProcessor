﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample.Interfaces
{
    public interface IPaymentProcessor
    {
        void Initialize();
        void ProcessPayment();
    }
}

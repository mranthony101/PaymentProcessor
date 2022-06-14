using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample
{
    public abstract class AbstractExample
    {
        public void Refuel()
        {
            Console.WriteLine("Initialized from the abstact class");
        }

        public abstract void TestMethod();
    }
}

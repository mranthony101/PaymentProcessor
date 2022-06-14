using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExample.Models
{
    public class Car : AbstractExample
    {

        public override void TestMethod()
        {
            Console.WriteLine("This is a car!");
        }

        private void DoCarStuff()
        {

        }
    }
}

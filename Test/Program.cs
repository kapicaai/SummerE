using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BillingHandler handler = new BillingHandler();
            handler.Add(new Client("Cat Cat"));
        }
    }
}

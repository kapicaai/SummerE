using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem;

namespace Test
{
    class Client : IUser
    {
        public string FullName
        {
            get; private set;
        }

        public Client(string name)
        {
            FullName = name;
        }
    }
}

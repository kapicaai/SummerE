using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation
{
    class CallInfo
    {
        public Port From { get; }
        public Port To { get; }
        public TimeSpan Duration { get; }

        public CallInfo()
        {

        }
    }
}

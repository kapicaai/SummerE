using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation
{
    public class Port : IPort
    {
        public PortCondition ConditionFlags { get; private set; }

        public void OnTerminalBecomeBusy(object sender, ITerminal arguments)
        {

        }

        public void OnTerminalBecomeFree(object sender, ITerminal arguments)
        {

        }

        public void LostConnection()
        {
            ConditionFlags = 0;
        }
    }
}

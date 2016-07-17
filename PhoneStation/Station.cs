using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation
{
    public class Station
    {
        public IDictionary<IPort, ITerminal> PortTerminalMapping { get; private set; }
        public ICollection<IPort> Ports { get; private set; }

        public void AddTerminal(ITerminal terminal)
        {
            var emptyPorts = from port in Ports
                           where PortCondition.Empty == 0
                           select port;
            if (emptyPorts.Count() > 0)
            {
                IPort port = emptyPorts.First();
                (terminal as Terminal).terminalBecomeBusy += (port as Port).OnTerminalBecomeBusy;
                (terminal as Terminal).terminalBecomeFree += (port as Port).OnTerminalBecomeFree;
            }
        }
    }
}

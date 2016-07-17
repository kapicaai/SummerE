using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation
{
    public class Terminal : ITerminal
    {
        public TerminalNumber Number { get; }

        public event EventHandler<ITerminal> terminalBecomeBusy;
        public event EventHandler<ITerminal> terminalBecomeFree;

    }
}

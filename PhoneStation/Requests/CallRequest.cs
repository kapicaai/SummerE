using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation
{
    class CallRequest : IRequest
    {
        public TerminalNumber Source { get; }
        public TerminalNumber Target { get; }

        public CallRequest(TerminalNumber source, TerminalNumber target)
        {
            Source = source;
            Target = target;
        }

        public CallRequest(long sourceNumber, long targetNumber)
        {
            Source = new TerminalNumber(sourceNumber);
            Target = new TerminalNumber(targetNumber);
        }
    }
}

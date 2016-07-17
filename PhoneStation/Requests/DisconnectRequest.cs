using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation.Requests
{
    public class DisconnectRequest : IRequest
    {
        public TerminalNumber Source { get; }
    }
}

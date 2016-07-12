using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneStation
{
    [Flags]
    public enum PortCondition
    {
        Busy = 1,
        Connected = 2,
        Empty = 4
    }
}
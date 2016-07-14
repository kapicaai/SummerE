using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation
{
    public interface IPort
    {
        PortCondition ConditionFlags { get; }
    }
}

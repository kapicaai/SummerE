﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStation
{
    interface IPort
    {
        PortCondition ConditionFlags { get; }
    }
}

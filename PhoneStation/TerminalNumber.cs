﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneStation
{
    public struct TerminalNumber
    {
        long Number { get; }
        public TerminalNumber(long number)
        {
            Number = number;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Attributes
{
    public class ElementTypeAttribute : Attribute
    {
        public ElementTypeAttribute(string val)
        {
            Type = val;
        }

        public string Type { get; private set; }
    }
}

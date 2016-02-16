﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd.Parser
{
    public class XmlElement
    {
        public IEnumerable<XmlAttribute> Attributes { get; set; }

        public string Name { get; set; }
    }
}

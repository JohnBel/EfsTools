using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Attributes
{
    public class AttributesAttribute : Attribute
    {
        public AttributesAttribute(int attributes)
        {
            Attributes = attributes;
        }

        public int Attributes { get; private set; }
    }
}

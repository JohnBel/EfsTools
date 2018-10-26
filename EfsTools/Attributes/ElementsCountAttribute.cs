using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Attributes
{
    public class ElementsCountAttribute : Attribute
    {
        public ElementsCountAttribute(int val)
        {
            Value = val;
        }

        public int Value { get; private set; }
    }
}

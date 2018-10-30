using System;

namespace EfsTools.Attributes
{
    public class ElementsCountAttribute : Attribute
    {
        public ElementsCountAttribute(int val)
        {
            Value = val;
        }

        public int Value { get; }
    }
}
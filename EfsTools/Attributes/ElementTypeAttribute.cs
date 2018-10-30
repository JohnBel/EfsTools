using System;

namespace EfsTools.Attributes
{
    public class ElementTypeAttribute : Attribute
    {
        public ElementTypeAttribute(string val)
        {
            Type = val;
        }

        public string Type { get; }
    }
}
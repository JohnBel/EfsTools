using System;

namespace EfsTools.Attributes
{
    public class AttributesAttribute : Attribute
    {
        public AttributesAttribute(int attributes)
        {
            Attributes = attributes;
        }

        public int Attributes { get; }
    }
}
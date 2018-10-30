using System;

namespace EfsTools.Attributes
{
    public class NvItemIdAttribute : Attribute
    {
        public NvItemIdAttribute(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
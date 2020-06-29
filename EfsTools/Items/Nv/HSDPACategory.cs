using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4118)]
    [Attributes(9)]
    public sealed class HsdpaCategory
    {
        public byte Value { get; set; }
    }
}
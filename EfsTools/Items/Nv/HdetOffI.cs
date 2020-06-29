using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(143)]
    [Attributes(9)]
    public sealed class HdetOff
    {
        public byte Value { get; set; }
    }
}
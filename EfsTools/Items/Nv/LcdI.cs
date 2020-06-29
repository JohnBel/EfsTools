using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(72)]
    [Attributes(9)]
    public sealed class Lcd
    {
        public byte Value { get; set; }
    }
}
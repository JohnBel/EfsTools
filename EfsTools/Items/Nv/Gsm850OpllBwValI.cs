using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2776)]
    [Attributes(9)]
    public sealed class Gsm850OpllBwVal
    {
        public byte Value { get; set; }
    }
}
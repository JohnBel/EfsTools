using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6709)]
    [Attributes(9)]
    public sealed class LteB1EncBtf
    {
        public int Value { get; set; }
    }
}
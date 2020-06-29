using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6552)]
    [Attributes(9)]
    public sealed class LteB7EncBtf
    {
        public int Value { get; set; }
    }
}
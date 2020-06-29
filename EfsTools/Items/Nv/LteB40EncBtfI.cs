using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6657)]
    [Attributes(9)]
    public sealed class LteB40EncBtf
    {
        public int Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3370)]
    [Attributes(9)]
    public sealed class Mf700AgcVsFreq
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}
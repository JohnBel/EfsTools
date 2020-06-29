using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6642)]
    [Attributes(9)]
    public sealed class LteB17C1RxGainVsFreq
    {
        [FieldCount(128)]
        public byte[] Value { get; set; }
    }
}
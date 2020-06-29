using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6736)]
    [Attributes(9)]
    public sealed class LteB1TxLimitVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
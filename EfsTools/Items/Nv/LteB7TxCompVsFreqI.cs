using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6577)]
    [Attributes(9)]
    public sealed class LteB7TxCompVsFreq
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}
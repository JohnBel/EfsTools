using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2322)]
    [Attributes(9)]
    public sealed class GsmC1TxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
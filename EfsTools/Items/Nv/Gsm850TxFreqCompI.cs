using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1137)]
    [Attributes(9)]
    public sealed class Gsm850TxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
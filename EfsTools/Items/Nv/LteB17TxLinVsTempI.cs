using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6612)]
    [Attributes(9)]
    public sealed class LteB17TxLinVsTemp
    {
        [FieldCount(64)]
        public sbyte[] Value { get; set; }
    }
}
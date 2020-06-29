using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6559)]
    [Attributes(9)]
    public sealed class LteB7TxLinVsTemp
    {
        [FieldCount(64)]
        public sbyte[] Value { get; set; }
    }
}
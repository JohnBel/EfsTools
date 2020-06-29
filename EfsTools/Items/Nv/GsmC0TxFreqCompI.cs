using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2319)]
    [Attributes(9)]
    public sealed class GsmC0TxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
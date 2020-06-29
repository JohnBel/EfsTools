using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2325)]
    [Attributes(9)]
    public sealed class GsmEnableTxFreqCompVsPcl
    {
        [FieldCount(15)]
        public sbyte[] Value { get; set; }
    }
}
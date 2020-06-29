using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4213)]
    [Attributes(9)]
    public sealed class GsmPathDelayCompFreqTbl
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}
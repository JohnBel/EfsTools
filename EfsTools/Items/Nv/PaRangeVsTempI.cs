using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(204)]
    [Attributes(9)]
    public sealed class PaRangeVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
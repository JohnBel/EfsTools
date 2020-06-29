using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7225)]
    [Attributes(9)]
    public sealed class LteB17C1RxGainVsFreqI
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}
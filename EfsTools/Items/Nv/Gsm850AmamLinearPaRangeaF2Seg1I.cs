using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5605)]
    [Attributes(9)]
    public sealed class Gsm850AmamLinearPaRangeaF2Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4871)]
    [Attributes(9)]
    public sealed class GsmDcsCarrierSuppression
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}
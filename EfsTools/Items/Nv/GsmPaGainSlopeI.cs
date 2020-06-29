using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(802)]
    [Attributes(9)]
    public sealed class GsmPaGainSlope
    {
        [FieldCount(15)]
        public byte[] Value { get; set; }
    }
}
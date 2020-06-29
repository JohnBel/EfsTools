using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1136)]
    [Attributes(9)]
    public sealed class Gsm850PaGainSlope
    {
        [FieldCount(15)]
        public byte[] Value { get; set; }
    }
}
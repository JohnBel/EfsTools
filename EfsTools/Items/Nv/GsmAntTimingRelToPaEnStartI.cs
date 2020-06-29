using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3064)]
    [Attributes(9)]
    public sealed class GsmAntTimingRelToPaEnStart
    {
        public short Value { get; set; }
    }
}
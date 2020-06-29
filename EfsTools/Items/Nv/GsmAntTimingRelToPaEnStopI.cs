using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3071)]
    [Attributes(9)]
    public sealed class GsmAntTimingRelToPaEnStop
    {
        public short Value { get; set; }
    }
}
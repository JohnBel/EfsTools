using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3150)]
    [Attributes(9)]
    public sealed class Gsm850AntTimingRelToPaEnStart
    {
        public short Value { get; set; }
    }
}
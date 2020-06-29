using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3075)]
    [Attributes(9)]
    public sealed class Gsm850AntTimingRelToPaEnStop
    {
        public short Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6348)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR2TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}
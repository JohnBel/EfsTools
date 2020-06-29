using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6343)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR1TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}
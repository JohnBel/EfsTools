using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5396)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaTempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5395)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaTempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}
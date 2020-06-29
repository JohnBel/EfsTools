using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1101)]
    [Attributes(9)]
    public sealed class Gsm850CalArfcn
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}
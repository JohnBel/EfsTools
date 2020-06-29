using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2752)]
    [Attributes(9)]
    public sealed class Gsm850CalpathRsb
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}
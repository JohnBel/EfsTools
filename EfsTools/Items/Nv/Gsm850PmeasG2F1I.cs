using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5325)]
    [Attributes(9)]
    public sealed class Gsm850PmeasG2F1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
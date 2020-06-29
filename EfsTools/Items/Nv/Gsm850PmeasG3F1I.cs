using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5326)]
    [Attributes(9)]
    public sealed class Gsm850PmeasG3F1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
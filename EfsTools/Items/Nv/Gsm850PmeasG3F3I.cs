using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5418)]
    [Attributes(9)]
    public sealed class Gsm850PmeasG3F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
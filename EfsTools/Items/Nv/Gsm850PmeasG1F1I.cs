using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5324)]
    [Attributes(9)]
    public sealed class Gsm850PmeasG1F1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
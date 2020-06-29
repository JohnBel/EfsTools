using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5294)]
    [Attributes(9)]
    public sealed class Gsm850RgiG3F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
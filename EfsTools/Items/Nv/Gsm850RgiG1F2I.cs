using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5296)]
    [Attributes(9)]
    public sealed class Gsm850RgiG1F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
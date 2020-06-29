using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5292)]
    [Attributes(9)]
    public sealed class Gsm850RgiG1F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
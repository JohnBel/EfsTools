using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5295)]
    [Attributes(9)]
    public sealed class Gsm850RgiG0F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
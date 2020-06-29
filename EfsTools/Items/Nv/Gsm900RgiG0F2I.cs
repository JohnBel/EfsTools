using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5303)]
    [Attributes(9)]
    public sealed class Gsm900RgiG0F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5405)]
    [Attributes(9)]
    public sealed class Gsm900RgiG2F3
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
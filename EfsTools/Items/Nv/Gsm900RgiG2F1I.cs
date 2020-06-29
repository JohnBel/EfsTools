using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5301)]
    [Attributes(9)]
    public sealed class Gsm900RgiG2F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
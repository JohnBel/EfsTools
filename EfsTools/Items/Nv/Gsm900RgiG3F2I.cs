using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5306)]
    [Attributes(9)]
    public sealed class Gsm900RgiG3F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
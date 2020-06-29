using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5302)]
    [Attributes(9)]
    public sealed class Gsm900RgiG3F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
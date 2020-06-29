using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5404)]
    [Attributes(9)]
    public sealed class Gsm900RgiG1F3
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}
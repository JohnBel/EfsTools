using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5422)]
    [Attributes(9)]
    public sealed class Gsm900PmeasG3F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
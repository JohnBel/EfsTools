using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5421)]
    [Attributes(9)]
    public sealed class Gsm900PmeasG2F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
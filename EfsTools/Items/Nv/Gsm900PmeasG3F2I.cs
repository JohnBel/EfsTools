using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5338)]
    [Attributes(9)]
    public sealed class Gsm900PmeasG3F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
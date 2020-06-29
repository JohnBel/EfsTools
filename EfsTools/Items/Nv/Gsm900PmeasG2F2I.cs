using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5337)]
    [Attributes(9)]
    public sealed class Gsm900PmeasG2F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
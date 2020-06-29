using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1133)]
    [Attributes(9)]
    public sealed class Gsm850TxBurstRampDownIndex12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}
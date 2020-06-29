using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1130)]
    [Attributes(9)]
    public sealed class Gsm850TxBurstRampDownIndex09
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}
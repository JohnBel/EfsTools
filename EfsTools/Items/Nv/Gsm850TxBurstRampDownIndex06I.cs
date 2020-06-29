using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1127)]
    [Attributes(9)]
    public sealed class Gsm850TxBurstRampDownIndex06
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}
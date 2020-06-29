using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1118)]
    [Attributes(9)]
    public sealed class Gsm850TxBurstRampUpIndex12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}
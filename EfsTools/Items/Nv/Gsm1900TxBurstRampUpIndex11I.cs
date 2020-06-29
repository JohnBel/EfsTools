using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1073)]
    [Attributes(9)]
    public sealed class Gsm1900TxBurstRampUpIndex11
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}
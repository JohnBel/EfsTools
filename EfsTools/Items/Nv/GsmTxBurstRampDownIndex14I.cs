using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(769)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}
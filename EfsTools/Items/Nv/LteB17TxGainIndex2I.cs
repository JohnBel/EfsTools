using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6628)]
    [Attributes(9)]
    public sealed class LteB17TxGainIndex2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
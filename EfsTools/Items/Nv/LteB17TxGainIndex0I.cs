using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6626)]
    [Attributes(9)]
    public sealed class LteB17TxGainIndex0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6624)]
    [Attributes(9)]
    public sealed class LteB17TxLinMaster2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
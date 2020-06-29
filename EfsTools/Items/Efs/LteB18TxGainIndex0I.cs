using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020359", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB18TxGainIndex0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
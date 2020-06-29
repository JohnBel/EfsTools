using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020357", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB18TxLinMaster2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
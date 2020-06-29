using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024875", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxLinMaster3
    {
        [FieldCount(64)]
        public ushort[] TxLinMaster3 { get; set; }
    }
}
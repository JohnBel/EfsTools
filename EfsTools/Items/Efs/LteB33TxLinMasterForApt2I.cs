using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024908", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxLinMasterForApt2
    {
        [FieldCount(64)]
        public ushort[] TxLinMasterForApt2 { get; set; }
    }
}
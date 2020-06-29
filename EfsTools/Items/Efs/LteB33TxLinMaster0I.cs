using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024872", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxLinMaster0
    {
        [FieldCount(64)]
        public ushort[] TxLinMaster0 { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024862", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxLinVsTemp
    {
        [FieldCount(64)]
        public sbyte[] TxLinVsTemp { get; set; }
    }
}
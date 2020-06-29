using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024911", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxGainIndexForApt1
    {
        [FieldCount(64)]
        public ushort[] TxGainIndexForApt1 { get; set; }
    }
}
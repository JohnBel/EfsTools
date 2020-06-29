using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024910", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxGainIndexForApt0
    {
        [FieldCount(64)]
        public ushort[] TxGainIndexForApt0 { get; set; }
    }
}
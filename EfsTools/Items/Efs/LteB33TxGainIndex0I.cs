using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024876", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxGainIndex0
    {
        [FieldCount(64)]
        public ushort[] TxGainIndex0 { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024878", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxGainIndex2
    {
        [FieldCount(64)]
        public ushort[] TxGainIndex2 { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024870", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxDigitalGainComp
    {
        [FieldCount(16)]
        public short[] LteTxDigitalGainComp { get; set; }
    }
}
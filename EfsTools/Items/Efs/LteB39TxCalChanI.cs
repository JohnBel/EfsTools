using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023583", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB39TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
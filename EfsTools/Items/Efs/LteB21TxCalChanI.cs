using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023157", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
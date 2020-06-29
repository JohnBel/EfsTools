using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020306", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB3TxGainIndex2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
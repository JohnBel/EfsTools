using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021292", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB40TxGainIndexForApt1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
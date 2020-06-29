using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023678", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB34TxGainIndex3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
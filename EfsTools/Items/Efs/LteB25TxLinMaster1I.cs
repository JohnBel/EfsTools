using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022321", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB25TxLinMaster1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
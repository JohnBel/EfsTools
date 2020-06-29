using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022161", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB12TxLinMaster1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
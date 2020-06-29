using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020716", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CellAptCharTblPout2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}
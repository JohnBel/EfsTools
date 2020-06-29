using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020717", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CellAptCharTblPout3
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}
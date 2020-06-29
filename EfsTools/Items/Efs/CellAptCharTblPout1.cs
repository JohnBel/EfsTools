using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020715", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CellAptCharTblPout1
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}
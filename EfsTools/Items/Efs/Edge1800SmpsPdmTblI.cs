using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021330", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Edge1800SmpsPdmTbl
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
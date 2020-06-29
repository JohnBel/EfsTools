using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021328", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Edge850SmpsPdmTbl
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
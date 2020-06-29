using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024193", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1900SmpsPdmPerPaRangeTbl
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
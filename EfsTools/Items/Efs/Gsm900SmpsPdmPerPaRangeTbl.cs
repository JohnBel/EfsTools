using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024191", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm900SmpsPdmPerPaRangeTbl
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
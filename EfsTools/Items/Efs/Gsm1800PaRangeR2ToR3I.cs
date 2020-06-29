using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020905", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1800PaRangeR2ToR3
    {
        public ushort Value { get; set; }
    }
}
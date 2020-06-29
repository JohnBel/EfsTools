using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022336", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB25C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}
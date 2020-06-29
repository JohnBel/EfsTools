using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024895", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C0C1Delay
    {
        public sbyte C0C1Delay { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020425", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023687", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB34C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}
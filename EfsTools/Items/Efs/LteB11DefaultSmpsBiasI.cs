using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024024", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB11DefaultSmpsBias
    {
        public ushort Value { get; set; }
    }
}
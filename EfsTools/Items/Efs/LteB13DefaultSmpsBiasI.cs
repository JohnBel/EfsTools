using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024026", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB13DefaultSmpsBias
    {
        public ushort Value { get; set; }
    }
}
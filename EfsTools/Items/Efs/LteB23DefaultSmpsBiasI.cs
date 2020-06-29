using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024352", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23DefaultSmpsBias
    {
        public ushort Value { get; set; }
    }
}
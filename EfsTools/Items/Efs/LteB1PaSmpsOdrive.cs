using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020752", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB1PaSmpsOdrive
    {
        public ushort Value { get; set; }
    }
}
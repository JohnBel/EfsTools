using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022269", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB24PaSmpsOdrive
    {
        public ushort Value { get; set; }
    }
}
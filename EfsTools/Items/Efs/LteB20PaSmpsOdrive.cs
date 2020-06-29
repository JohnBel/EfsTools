using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020779", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB20PaSmpsOdrive
    {
        public ushort Value { get; set; }
    }
}
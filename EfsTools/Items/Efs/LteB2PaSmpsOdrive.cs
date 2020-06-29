using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020755", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB2PaSmpsOdrive
    {
        public ushort Value { get; set; }
    }
}
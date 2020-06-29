using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022372", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB1RxOnRiseDelay
    {
        public ushort Value { get; set; }
    }
}
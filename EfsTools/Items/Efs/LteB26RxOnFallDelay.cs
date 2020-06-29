using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024702", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26RxOnFallDelay
    {
        public ushort Value { get; set; }
    }
}
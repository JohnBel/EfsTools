using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022293", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB25RxDelay
    {
        public short Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/common/lte_category", true, 0xE1FF)]
    [Attributes(9)]
    public class LteCategory
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        public byte Value { get; set; }
    }
}
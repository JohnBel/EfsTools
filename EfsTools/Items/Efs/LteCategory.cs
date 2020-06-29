using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/lte/common/lte_category", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteCategory
    {
        public byte Value { get; set; }
    }
}
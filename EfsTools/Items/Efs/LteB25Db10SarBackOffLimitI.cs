using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022360", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB25Db10SarBackOffLimit
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}
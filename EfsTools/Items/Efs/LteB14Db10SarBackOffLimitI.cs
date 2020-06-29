using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024428", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB14Db10SarBackOffLimit
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}
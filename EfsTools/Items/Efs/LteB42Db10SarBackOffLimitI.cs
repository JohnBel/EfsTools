using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024522", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB42Db10SarBackOffLimit
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}
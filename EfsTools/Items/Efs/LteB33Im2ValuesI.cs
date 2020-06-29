using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024853", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33Im2Values
    {
        [FieldCount(3)]
        public byte[] Im2ValuesType { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024893", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1Im2Values
    {
        [FieldCount(3)]
        public byte[] C1Im2ValuesType { get; set; }
    }
}
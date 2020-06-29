using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024884", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33Antsel
    {
        [FieldCount(4)]
        public byte[] Antsel { get; set; }
    }
}
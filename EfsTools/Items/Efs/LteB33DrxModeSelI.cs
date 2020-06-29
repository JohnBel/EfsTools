using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024896", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33DrxModeSel
    {
        [FieldCount(3)]
        public byte[] RfDrxModeSel { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024914", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33Db10SarBackOffLimit
    {
        [FieldCount(8)]
        public ushort[] LteDb10SarBackOffLimit { get; set; }
    }
}
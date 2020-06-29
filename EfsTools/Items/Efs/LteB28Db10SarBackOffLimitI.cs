using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025478", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB28Db10SarBackOffLimit
    {
        [FieldCount(8)]
        public ushort[] LteDb10SarBackOffLimit { get; set; }
    }
}
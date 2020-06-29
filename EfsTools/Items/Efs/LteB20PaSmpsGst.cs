using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020778", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB20PaSmpsGst
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
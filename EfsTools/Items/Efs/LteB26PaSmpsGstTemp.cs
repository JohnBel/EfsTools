using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024675", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26PaSmpsGstTemp
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
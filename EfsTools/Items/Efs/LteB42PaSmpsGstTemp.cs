using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024512", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB42PaSmpsGstTemp
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
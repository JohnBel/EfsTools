using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023701", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB34PaSmpsGstTemp
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
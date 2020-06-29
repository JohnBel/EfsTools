using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024126", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class InternalDeviceCalStatus
    {
        public TxIntDevCalNvType Value { get; set; }
    }
}
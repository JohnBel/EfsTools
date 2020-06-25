using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024254", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxMultiLinV3Data
    {
        public VariantMarker VariantDataMarker { get; set; }
    }
}
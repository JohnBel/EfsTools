using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024256", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma900TxMultiLinV3Data
    {
        public VariantMarker VariantDataMarker { get; set; }
    }
}
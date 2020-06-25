using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024255", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma800TxMultiLinV3Data
    {
        public VariantMarker VariantDataMarker { get; set; }
    }
}
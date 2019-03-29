using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024210", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC0Bc0TxMultiLinV3Data
    {
        [ElementsCount(1)]
        [ElementType("Variant_Marker")]
        [Description("")]
        public VariantMarker VariantDataMarker { get; set; }
        
    }
}

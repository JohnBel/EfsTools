using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024212", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc4TxMultiLinV3Data
    {
        public VariantMarker VariantDataMarker { get; set; }
    }
}
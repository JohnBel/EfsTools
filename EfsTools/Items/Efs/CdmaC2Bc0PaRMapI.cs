using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021744", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0PaRMap
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021925", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc5HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}
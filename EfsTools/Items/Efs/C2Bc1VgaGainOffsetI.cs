using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021778", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc1VgaGainOffset
    {
        public short Value { get; set; }
    }
}
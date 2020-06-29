using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022084", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15VgaGainOffset
    {
        public short Value { get; set; }
    }
}
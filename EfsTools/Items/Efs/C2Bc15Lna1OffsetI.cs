using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022086", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc15Lna1Offset
    {
        public short Value { get; set; }
    }
}
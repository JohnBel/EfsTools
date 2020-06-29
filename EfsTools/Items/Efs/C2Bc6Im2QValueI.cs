using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021942", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6Im2QValue
    {
        public byte Value { get; set; }
    }
}
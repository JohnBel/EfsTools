using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023816", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB4VgaGainOffsetCar1
    {
        public short Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024608", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaBc4HdetModRange
    {
        [FieldCount(8)]
        public short[] LowerBoundOffset { get; set; }

        [FieldCount(8)]
        public short[] UpperBoundOffset { get; set; }
    }
}
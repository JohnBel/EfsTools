using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024609", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma800HdetModRange
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] LowerBoundOffset { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] UpperBoundOffset { get; set; }
    }
}
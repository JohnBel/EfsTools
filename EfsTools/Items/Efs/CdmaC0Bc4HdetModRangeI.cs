using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024789", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc4HdetModRange
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] LowerBoundOffset
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] UpperBoundOffset
        {
            get;
        }
    }
}
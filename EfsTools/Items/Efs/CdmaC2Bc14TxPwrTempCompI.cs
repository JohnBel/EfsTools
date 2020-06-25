using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023226", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxPwrTempComp
    {
        public sbyte Reserved { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] Pa0PowerOffset
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Pa0PowerSlope
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] Pa1PowerOffset
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Pa1PowerSlope
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] Pa2PowerOffset
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Pa2PowerSlope
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] Pa3PowerOffset
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Pa3PowerSlope
        {
            get;
        }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024829", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc15GnssIm3Desense
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public short[] Cdma1xBc1DoBc15Im3Desense
        {
            get;
        }
    }
}
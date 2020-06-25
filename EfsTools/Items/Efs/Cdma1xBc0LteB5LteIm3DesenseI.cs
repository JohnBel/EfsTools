using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025131", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB5LteIm3Desense
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] Cdma1xBc0LteBc5LteIm3Desense
        {
            get;
        }
    }
}
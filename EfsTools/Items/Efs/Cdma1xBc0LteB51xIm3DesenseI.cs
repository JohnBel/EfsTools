using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025130", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB51xIm3Desense
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] Cdma1xBc0LteBc51xIm3Desense
        {
            get;
        }
    }
}
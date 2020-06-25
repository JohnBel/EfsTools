using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025129", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc0HdrIm3Desense
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] Cdma1xBc0DoBcoHdrIm3Desense
        {
            get;
        }
    }
}
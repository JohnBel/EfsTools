using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025128", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB12B171x3rdHarmonicDesense
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] Cdma1xBc15LteB12B173rdHarmonicDesense
        {
            get;
        }
    }
}
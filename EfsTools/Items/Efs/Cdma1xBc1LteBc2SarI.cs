using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022921", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc2Sar
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public short[] Value
        {
            get;
        }
    }
}
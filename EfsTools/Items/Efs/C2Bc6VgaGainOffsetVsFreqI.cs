using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021932", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc6VgaGainOffsetVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public sbyte[] Value
        {
            get;
        }
    }
}
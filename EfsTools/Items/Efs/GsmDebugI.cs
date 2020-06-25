using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025584", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmDebug
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] SpareNv { get; set; }
    }
}
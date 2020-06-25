using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022982", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class MsmSelfCal
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16384)]
        public sbyte[] Reserved { get; set; }
    }
}
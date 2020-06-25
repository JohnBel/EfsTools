using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024886", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1NonbypassBypassTimer
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] C1NonbypassBypassTimerType { get; set; }
    }
}
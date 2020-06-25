using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025478", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB28Db10SarBackOffLimit
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] LteDb10SarBackOffLimit { get; set; }
    }
}
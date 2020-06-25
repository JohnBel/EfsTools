using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024914", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33Db10SarBackOffLimit
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] LteDb10SarBackOffLimit { get; set; }
    }
}
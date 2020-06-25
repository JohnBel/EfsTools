using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024878", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxGainIndex2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ushort[] TxGainIndex2 { get; set; }
    }
}
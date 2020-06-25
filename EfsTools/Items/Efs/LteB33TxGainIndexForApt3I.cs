using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024913", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxGainIndexForApt3
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ushort[] TxGainIndexForApt3 { get; set; }
    }
}
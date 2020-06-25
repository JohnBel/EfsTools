using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024174", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB25TxEptDpdConfigParams
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] Value { get; set; }
    }
}
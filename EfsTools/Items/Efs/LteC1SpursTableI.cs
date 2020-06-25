using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023760", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteC1SpursTable
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
    }
}
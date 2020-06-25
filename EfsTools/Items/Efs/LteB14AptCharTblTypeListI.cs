using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024429", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB14AptCharTblTypeList
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] Value { get; set; }
    }
}
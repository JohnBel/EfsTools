using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024904", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33PaSmpsGstTemp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ushort[] SmpsPdmTempComp { get; set; }
    }
}
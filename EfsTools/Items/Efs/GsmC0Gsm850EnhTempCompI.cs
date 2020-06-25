using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025108", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm850EnhTempComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public short[] TempcompTable { get; set; }
    }
}
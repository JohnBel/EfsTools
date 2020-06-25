using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/mmode/mmode_1xsxlte_optimization", false, 0x81FF)]
    [Attributes(9)]
    public sealed class Mmode1xsxLteOptimization
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 51)]
        public byte[] Value { get; set; }
    }
}
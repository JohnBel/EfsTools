using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025360", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB24IntraCaRxGainVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)]
        public sbyte[] Value { get; set; }
    }
}
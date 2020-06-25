using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025179", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB3IntraCaRxGainVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)]
        public sbyte[] Value { get; set; }
    }
}
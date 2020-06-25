using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024196", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1800CharPredistEnvGain
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] Value { get; set; }
    }
}
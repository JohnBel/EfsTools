using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2500)]
    [Attributes(9)]
    public sealed class FactoryData4
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] Value { get; set; }
    }
}
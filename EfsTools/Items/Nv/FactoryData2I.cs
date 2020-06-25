using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2498)]
    [Attributes(9)]
    public sealed class FactoryData2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] Value { get; set; }
    }
}
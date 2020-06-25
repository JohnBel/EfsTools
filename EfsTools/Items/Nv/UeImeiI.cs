using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(550)]
    [Attributes(9)]
    public sealed class UeImei
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public byte[] Value { get; set; }
    }
}
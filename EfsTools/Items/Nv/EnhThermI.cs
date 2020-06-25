using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5479)]
    [Attributes(9)]
    public sealed class EnhTherm
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Value { get; set; }
    }
}
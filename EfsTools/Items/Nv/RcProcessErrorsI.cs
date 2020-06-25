using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6861)]
    [Attributes(9)]
    public sealed class RcProcessErrors
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Value { get; set; }
    }
}
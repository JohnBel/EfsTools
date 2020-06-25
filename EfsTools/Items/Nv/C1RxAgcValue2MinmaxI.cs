using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(967)]
    [Attributes(9)]
    public sealed class C1RxAgcValue2Minmax
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Value { get; set; }
    }
}
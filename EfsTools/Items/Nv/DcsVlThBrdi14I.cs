using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2275)]
    [Attributes(9)]
    public sealed class DcsVlThBrdi14
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public ushort[] Value { get; set; }
    }
}
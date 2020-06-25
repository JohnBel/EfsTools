using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2325)]
    [Attributes(9)]
    public sealed class GsmEnableTxFreqCompVsPcl
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(916)]
    [Attributes(9)]
    public sealed class GsmGainrangeSwitchpoints
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public sbyte[] Value { get; set; }
    }
}
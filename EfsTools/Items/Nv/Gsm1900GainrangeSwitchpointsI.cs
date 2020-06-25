using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1100)]
    [Attributes(9)]
    public sealed class Gsm1900GainrangeSwitchpoints
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public sbyte[] Value { get; set; }
    }
}
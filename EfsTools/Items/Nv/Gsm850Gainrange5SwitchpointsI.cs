using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3507)]
    [Attributes(9)]
    public sealed class Gsm850Gainrange5Switchpoints
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Value { get; set; }
    }
}
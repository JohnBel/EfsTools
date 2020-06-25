using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3508)]
    [Attributes(9)]
    public sealed class Gsm1900Gainrange5Switchpoints
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Value { get; set; }
    }
}
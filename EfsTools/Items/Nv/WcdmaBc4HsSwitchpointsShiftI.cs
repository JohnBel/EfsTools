using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6053)]
    [Attributes(9)]
    public sealed class WcdmaBc4HsSwitchpointsShift
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6048)]
    [Attributes(9)]
    public sealed class Wcdma2100HsSwitchpointsShift
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Value { get; set; }
    }
}
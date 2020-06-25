using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3059)]
    [Attributes(9)]
    public sealed class GsmPowerLevels
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public short[] Value { get; set; }
    }
}
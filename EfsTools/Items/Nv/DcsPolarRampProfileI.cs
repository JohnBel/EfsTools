using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3509)]
    [Attributes(9)]
    public sealed class DcsPolarRampProfile
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public ushort[] Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2747)]
    [Attributes(9)]
    public sealed class Gsm850AmamDynamicRange
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] Value { get; set; }
    }
}
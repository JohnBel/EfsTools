using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5221)]
    [Attributes(9)]
    public sealed class C0Bc10VgaGainOffsetVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public sbyte[] Value
        {
            get;
        }
    }
}
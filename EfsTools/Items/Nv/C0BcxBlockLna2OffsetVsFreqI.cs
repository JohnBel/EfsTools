using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4576)]
    [Attributes(9)]
    public sealed class C0BcxBlockLna2OffsetVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public sbyte[] Value
        {
            get;
        }
    }
}
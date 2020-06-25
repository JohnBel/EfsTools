using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(490)]
    [Attributes(9)]
    public sealed class PwrBackoffVsVoltMed
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] Value { get; set; }
    }
}
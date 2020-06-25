using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5428)]
    [Attributes(9)]
    public sealed class Gsm1900PmeasG1F3
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ushort[] Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2750)]
    [Attributes(9)]
    public sealed class GsmCalpathRsb
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] Value { get; set; }
    }
}
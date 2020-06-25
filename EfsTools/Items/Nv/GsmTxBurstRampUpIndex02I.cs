using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(742)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex02
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public ushort[] Value { get; set; }
    }
}
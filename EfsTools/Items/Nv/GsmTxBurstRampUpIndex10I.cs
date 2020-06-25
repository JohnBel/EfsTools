using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(750)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex10
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public ushort[] Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3431)]
    [Attributes(9)]
    public sealed class GsmPaTransitionTable
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public ushort[] Value { get; set; }
    }
}
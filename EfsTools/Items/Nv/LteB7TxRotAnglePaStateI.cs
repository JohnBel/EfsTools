using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6557)]
    [Attributes(9)]
    public sealed class LteB7TxRotAnglePaState
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] Value { get; set; }
    }
}
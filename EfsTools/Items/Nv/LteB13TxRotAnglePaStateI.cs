using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6506)]
    [Attributes(9)]
    public sealed class LteB13TxRotAnglePaState
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] Value { get; set; }
    }
}
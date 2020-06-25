using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3973)]
    [Attributes(9)]
    public sealed class Wcdma800TxPdmLin0
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ushort[] Value { get; set; }
    }
}
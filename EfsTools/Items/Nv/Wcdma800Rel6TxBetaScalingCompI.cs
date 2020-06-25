using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4947)]
    [Attributes(9)]
    public sealed class Wcdma800Rel6TxBetaScalingComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public ushort[] Value { get; set; }
    }
}
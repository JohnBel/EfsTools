using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2757)]
    [Attributes(9)]
    public sealed class Gsm1900AmamSysGainDcCorr
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] Value { get; set; }
    }
}
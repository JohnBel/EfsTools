using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4870)]
    [Attributes(9)]
    public sealed class Gsm850CarrierSuppression
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public short[] Value { get; set; }
    }
}
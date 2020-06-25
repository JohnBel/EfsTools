using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4385)]
    [Attributes(9)]
    public sealed class Gsm850RxGainRange4TempComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public short[] Value { get; set; }
    }
}
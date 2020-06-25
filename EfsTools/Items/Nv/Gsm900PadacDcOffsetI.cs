using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5286)]
    [Attributes(9)]
    public sealed class Gsm900PadacDcOffset
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public sbyte[] Value { get; set; }
    }
}
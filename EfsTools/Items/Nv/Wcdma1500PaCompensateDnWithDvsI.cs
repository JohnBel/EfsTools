using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6994)]
    [Attributes(9)]
    public sealed class Wcdma1500PaCompensateDnWithDvs
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public short[] Value { get; set; }
    }
}
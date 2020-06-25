using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(573)]
    [Attributes(9)]
    public sealed class RfCalDatFile
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public byte[] Value { get; set; }
    }
}
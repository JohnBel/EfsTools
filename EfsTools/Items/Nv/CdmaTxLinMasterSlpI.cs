using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(133)]
    [Attributes(9)]
    public sealed class CdmaTxLinMasterSlp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public byte[] Value { get; set; }
    }
}
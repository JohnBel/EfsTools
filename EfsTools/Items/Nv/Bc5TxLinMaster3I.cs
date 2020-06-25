using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1395)]
    [Attributes(9)]
    public sealed class Bc5TxLinMaster3
    {
        public short Value1 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public byte[] Value2
        {
            get;
        }
    }
}
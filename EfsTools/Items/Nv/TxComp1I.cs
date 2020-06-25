using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(420)]
    [Attributes(9)]
    public sealed class TxComp1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public sbyte[] Value { get; set; }
    }
}
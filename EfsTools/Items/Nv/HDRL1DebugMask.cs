using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4231)]
    [Attributes(9)]
    public sealed class HdrL1DebugMask
    {
        public ulong Field1 { get; set; }


        public ulong Field2 { get; set; }
    }
}
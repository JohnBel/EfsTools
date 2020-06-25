using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1892)]
    [Attributes(9)]
    public sealed class DiagDebugControl
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(814)]
    [Attributes(9)]
    public sealed class DcsPrecharge
    {
        public ushort Value { get; set; }
    }
}
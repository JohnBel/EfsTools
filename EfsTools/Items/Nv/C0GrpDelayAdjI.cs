using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(972)]
    [Attributes(9)]
    public sealed class C0GrpDelayAdj
    {
        public byte Value { get; set; }
    }
}
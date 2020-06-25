using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(666)]
    [Attributes(9)]
    public sealed class GpsDaccQaccum0
    {
        public byte Value { get; set; }
    }
}
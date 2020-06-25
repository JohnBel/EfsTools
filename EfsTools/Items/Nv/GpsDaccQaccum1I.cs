using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(670)]
    [Attributes(9)]
    public sealed class GpsDaccQaccum1
    {
        public byte Value { get; set; }
    }
}
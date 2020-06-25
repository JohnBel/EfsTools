using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(676)]
    [Attributes(9)]
    public sealed class PcsDaccQaccum3
    {
        public byte Value { get; set; }
    }
}
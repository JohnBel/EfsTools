using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1896)]
    [Attributes(9)]
    public sealed class Ipv6Enabled
    {
        public byte Value { get; set; }
    }
}
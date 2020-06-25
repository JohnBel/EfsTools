using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(154)]
    [Attributes(9)]
    public sealed class R3Fall
    {
        public byte Value { get; set; }
    }
}
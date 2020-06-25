using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(624)]
    [Attributes(9)]
    public sealed class PcsRxfCgQoffset
    {
        public uint Value { get; set; }
    }
}
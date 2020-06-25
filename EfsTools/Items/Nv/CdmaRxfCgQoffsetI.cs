using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(623)]
    [Attributes(9)]
    public sealed class CdmaRxfCgQoffset
    {
        public uint Value { get; set; }
    }
}
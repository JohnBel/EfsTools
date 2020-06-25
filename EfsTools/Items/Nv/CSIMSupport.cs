using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6253)]
    [Attributes(9)]
    public sealed class CSimSupport
    {
        public byte Value { get; set; }
    }
}
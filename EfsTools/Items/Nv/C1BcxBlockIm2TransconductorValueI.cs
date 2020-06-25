using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4614)]
    [Attributes(9)]
    public sealed class C1BcxBlockIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
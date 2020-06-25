using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(837)]
    [Attributes(9)]
    public sealed class CdmaIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
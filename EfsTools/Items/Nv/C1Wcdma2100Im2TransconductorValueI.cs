using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3786)]
    [Attributes(9)]
    public sealed class C1Wcdma2100Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
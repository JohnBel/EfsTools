using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3844)]
    [Attributes(9)]
    public sealed class C1Wcdma800Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
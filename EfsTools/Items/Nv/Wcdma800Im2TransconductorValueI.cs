using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1829)]
    [Attributes(9)]
    public sealed class Wcdma800Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
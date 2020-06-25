using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(693)]
    [Attributes(9)]
    public sealed class CdmaVgaGainOffset
    {
        public short Value { get; set; }
    }
}
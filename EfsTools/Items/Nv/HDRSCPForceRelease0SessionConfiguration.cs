using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4204)]
    [Attributes(9)]
    public sealed class HdrScpForceRelease0SessionConfiguration
    {
        public byte Value { get; set; }
    }
}
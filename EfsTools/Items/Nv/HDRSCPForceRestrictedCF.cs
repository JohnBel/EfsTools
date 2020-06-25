using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6832)]
    [Attributes(9)]
    public sealed class HdrScpForceRestrictedCf
    {
        public byte Value { get; set; }
    }
}
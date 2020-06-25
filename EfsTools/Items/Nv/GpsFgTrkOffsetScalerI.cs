using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(614)]
    [Attributes(9)]
    public sealed class GpsFgTrkOffsetScaler
    {
        public byte Value { get; set; }
    }
}
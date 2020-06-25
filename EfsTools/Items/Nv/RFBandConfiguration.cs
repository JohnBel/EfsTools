using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1877)]
    [Attributes(9)]
    public sealed class RfBandConfiguration
    {
        public ulong Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2904)]
    [Attributes(9)]
    public sealed class Wcdma1800AgcTxOnFallDelay
    {
        public ushort Value { get; set; }
    }
}
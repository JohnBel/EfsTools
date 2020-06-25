using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(338)]
    [Attributes(9)]
    public sealed class PcsR1Fall
    {
        public byte Value { get; set; }
    }
}
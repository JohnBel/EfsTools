using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2940)]
    [Attributes(9)]
    public sealed class Wcdma1800HsR1Fall
    {
        public short Value { get; set; }
    }
}
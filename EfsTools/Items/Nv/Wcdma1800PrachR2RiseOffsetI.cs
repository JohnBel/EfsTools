using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2927)]
    [Attributes(9)]
    public sealed class Wcdma1800PrachR2RiseOffset
    {
        public short Value { get; set; }
    }
}
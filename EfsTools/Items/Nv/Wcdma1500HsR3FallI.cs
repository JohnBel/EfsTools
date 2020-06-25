using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7052)]
    [Attributes(9)]
    public sealed class Wcdma1500HsR3Fall
    {
        public short Value { get; set; }
    }
}
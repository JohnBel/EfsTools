using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2942)]
    [Attributes(9)]
    public sealed class Wcdma1800HsR2Fall
    {
        public short Value { get; set; }
    }
}
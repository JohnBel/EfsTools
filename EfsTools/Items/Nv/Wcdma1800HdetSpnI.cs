using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2896)]
    [Attributes(9)]
    public sealed class Wcdma1800HdetSpn
    {
        public byte Value { get; set; }
    }
}
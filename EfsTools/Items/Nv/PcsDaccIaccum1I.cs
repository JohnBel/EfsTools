using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(648)]
    [Attributes(9)]
    public sealed class PcsDaccIaccum1
    {
        public byte Value { get; set; }
    }
}
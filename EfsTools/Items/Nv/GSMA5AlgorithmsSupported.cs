using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(553)]
    [Attributes(9)]
    public sealed class GsmA5AlgorithmsSupported
    {
        public byte Value { get; set; }
    }
}
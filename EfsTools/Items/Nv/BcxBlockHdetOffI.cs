using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4567)]
    [Attributes(9)]
    public sealed class BcxBlockHdetOff
    {
        public byte Value { get; set; }
    }
}
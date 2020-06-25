using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4568)]
    [Attributes(9)]
    public sealed class BcxBlockHdetSpn
    {
        public byte Value { get; set; }
    }
}
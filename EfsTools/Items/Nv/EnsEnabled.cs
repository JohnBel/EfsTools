using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3461)]
    [Attributes(9)]
    public sealed class EnsEnabled
    {
        public byte Value { get; set; }
    }
}
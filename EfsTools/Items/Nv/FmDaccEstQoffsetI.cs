using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(641)]
    [Attributes(9)]
    public sealed class FmDaccEstQoffset
    {
        public uint Value { get; set; }
    }
}
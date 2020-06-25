using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(659)]
    [Attributes(9)]
    public sealed class CdmaDaccIaccum4
    {
        public byte Value { get; set; }
    }
}
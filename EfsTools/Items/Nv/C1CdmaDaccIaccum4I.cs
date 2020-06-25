using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(996)]
    [Attributes(9)]
    public sealed class C1CdmaDaccIaccum4
    {
        public byte Value { get; set; }
    }
}
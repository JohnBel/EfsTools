using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(987)]
    [Attributes(9)]
    public sealed class C1CdmaDaccIaccum1
    {
        public byte Value { get; set; }
    }
}
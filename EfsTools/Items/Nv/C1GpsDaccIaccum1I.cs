using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(989)]
    [Attributes(9)]
    public sealed class C1GpsDaccIaccum1
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(679)]
    [Attributes(9)]
    public sealed class CdmaDaccQaccum4
    {
        public byte Value { get; set; }
    }
}
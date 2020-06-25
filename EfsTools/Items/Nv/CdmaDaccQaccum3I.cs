using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(675)]
    [Attributes(9)]
    public sealed class CdmaDaccQaccum3
    {
        public byte Value { get; set; }
    }
}
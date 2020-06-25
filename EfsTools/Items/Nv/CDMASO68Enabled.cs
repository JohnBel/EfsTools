using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4102)]
    [Attributes(9)]
    public sealed class CdmaSO68Enabled
    {
        public byte Value { get; set; }
    }
}
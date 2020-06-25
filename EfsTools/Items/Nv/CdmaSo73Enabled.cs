using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7166)]
    [Attributes(9)]
    public sealed class CdmaSo73Enabled
    {
        public byte Value { get; set; }
    }
}
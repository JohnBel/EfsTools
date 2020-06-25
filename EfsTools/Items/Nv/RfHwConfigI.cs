using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1878)]
    [Attributes(9)]
    public sealed class RfHwConfig
    {
        public byte Value { get; set; }
    }
}
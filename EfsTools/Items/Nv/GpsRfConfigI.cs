using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1032)]
    [Attributes(9)]
    public sealed class GpsRfConfig
    {
        public byte Value { get; set; }
    }
}
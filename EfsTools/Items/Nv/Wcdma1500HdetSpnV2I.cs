using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7125)]
    [Attributes(9)]
    public sealed class Wcdma1500HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}
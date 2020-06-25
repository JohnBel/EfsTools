using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(946)]
    [Attributes(41)]
    public sealed class ExpandBandPreference16To32Bits
    {
        public byte Nam { get; set; }


        public short Value { get; set; }
    }
}
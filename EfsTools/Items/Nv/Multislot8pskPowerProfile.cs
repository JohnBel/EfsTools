using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4158)]
    [Attributes(9)]
    public sealed class Multislot8pskPowerProfile
    {
        public byte Value { get; set; }
    }
}
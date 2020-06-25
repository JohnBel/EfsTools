using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4157)]
    [Attributes(9)]
    public sealed class MultislotGmskPowerProfile
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1030)]
    [Attributes(9)]
    public sealed class ForceUesgSnrGsmR99Version
    {
        public byte Value { get; set; }
    }
}
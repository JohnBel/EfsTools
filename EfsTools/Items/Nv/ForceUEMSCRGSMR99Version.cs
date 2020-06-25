using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1031)]
    [Attributes(9)]
    public sealed class ForceUemsCrGsmR99Version
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4192)]
    [Attributes(9)]
    public sealed class CdmaSO70Enable
    {
        public byte Value { get; set; }
    }
}
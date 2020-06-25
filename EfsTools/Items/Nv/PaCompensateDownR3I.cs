using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2024)]
    [Attributes(9)]
    public sealed class PaCompensateDownR3
    {
        public short Value { get; set; }
    }
}
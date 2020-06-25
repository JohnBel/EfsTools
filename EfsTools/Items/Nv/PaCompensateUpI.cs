using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1801)]
    [Attributes(9)]
    public sealed class PaCompensateUp
    {
        public short Value { get; set; }
    }
}
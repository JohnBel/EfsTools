using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(896)]
    [Attributes(9)]
    public sealed class UimFirstInstructionClass
    {
        public ushort Value { get; set; }
    }
}
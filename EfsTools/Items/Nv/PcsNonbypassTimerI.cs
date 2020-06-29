using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(390)]
    [Attributes(9)]
    public sealed class PcsNonbypassTimer
    {
        public byte Value { get; set; }
    }
}
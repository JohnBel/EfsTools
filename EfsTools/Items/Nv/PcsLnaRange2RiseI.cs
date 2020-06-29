using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(387)]
    [Attributes(9)]
    public sealed class PcsLnaRange2Rise
    {
        public sbyte Value { get; set; }
    }
}
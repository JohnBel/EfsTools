using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(253)]
    [Attributes(9)]
    public sealed class Pdm1VsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
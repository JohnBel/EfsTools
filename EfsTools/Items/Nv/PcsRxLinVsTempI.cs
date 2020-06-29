using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(350)]
    [Attributes(9)]
    public sealed class PcsRxLinVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6989)]
    [Attributes(9)]
    public sealed class Wcdma1500PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}
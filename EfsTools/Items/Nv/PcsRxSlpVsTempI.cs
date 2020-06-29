using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(355)]
    [Attributes(9)]
    public sealed class PcsRxSlpVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(422)]
    [Attributes(9)]
    public sealed class TxComp3
    {
        [FieldCount(32)]
        public sbyte[] Value { get; set; }
    }
}
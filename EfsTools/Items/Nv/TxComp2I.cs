using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(421)]
    [Attributes(9)]
    public sealed class TxComp2
    {
        [FieldCount(32)]
        public sbyte[] Value { get; set; }
    }
}
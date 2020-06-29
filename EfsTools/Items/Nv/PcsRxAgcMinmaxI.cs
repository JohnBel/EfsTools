using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(357)]
    [Attributes(9)]
    public sealed class PcsRxAgcMinmax
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
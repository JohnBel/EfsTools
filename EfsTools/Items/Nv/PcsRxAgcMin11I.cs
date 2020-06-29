using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(397)]
    [Attributes(9)]
    public sealed class PcsRxAgcMin11
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
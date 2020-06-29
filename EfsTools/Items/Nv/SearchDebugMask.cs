using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3632)]
    [Attributes(9)]
    public sealed class SearchDebugMask
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(493)]
    [Attributes(9)]
    public sealed class VbattMinMax
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
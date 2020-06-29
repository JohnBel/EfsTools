using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2328)]
    [Attributes(9)]
    public sealed class ThermCompThresholds
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
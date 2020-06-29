using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3849)]
    [Attributes(9)]
    public sealed class RfrVcoCoarseTune21900
    {
        [FieldCount(12)]
        public byte[] Value { get; set; }
    }
}
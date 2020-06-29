using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2912)]
    [Attributes(9)]
    public sealed class RfrVcoCoarseTuning1800
    {
        [FieldCount(12)]
        public byte[] Value { get; set; }
    }
}
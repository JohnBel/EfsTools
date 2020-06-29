using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1794)]
    [Attributes(9)]
    public sealed class RfrVcoCoarseTuning1900
    {
        [FieldCount(12)]
        public byte[] Value { get; set; }
    }
}
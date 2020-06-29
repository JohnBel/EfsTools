using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3752)]
    [Attributes(9)]
    public sealed class RfrVcoCoarseTuning900
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}
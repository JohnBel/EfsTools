using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4097)]
    [Attributes(9)]
    public sealed class RfrVcoCoarseTuningBc4
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}
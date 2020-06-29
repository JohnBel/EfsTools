using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(247)]
    [Attributes(9)]
    public sealed class RxAgcMinmax
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
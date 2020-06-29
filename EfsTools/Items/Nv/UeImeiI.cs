using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(550)]
    [Attributes(9)]
    public sealed class UeImei
    {
        [FieldCount(9)]
        public byte[] Value { get; set; }
    }
}
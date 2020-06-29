using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7008)]
    [Attributes(9)]
    public sealed class Wcdma1500Iaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
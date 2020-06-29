using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4165)]
    [Attributes(9)]
    public sealed class Wcdma1800Iaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
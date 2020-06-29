using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7009)]
    [Attributes(9)]
    public sealed class Wcdma1500Qaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
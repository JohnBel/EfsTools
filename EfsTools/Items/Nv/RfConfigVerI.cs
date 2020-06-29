using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(570)]
    [Attributes(9)]
    public sealed class RfConfigVer
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}
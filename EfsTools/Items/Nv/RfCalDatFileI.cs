using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(573)]
    [Attributes(9)]
    public sealed class RfCalDatFile
    {
        [FieldCount(9)]
        public byte[] Value { get; set; }
    }
}
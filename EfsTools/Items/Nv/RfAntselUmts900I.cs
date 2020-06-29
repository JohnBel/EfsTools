using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4098)]
    [Attributes(9)]
    public sealed class RfAntselUmts900
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}
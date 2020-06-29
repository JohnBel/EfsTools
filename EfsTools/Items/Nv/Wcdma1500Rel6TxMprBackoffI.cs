using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7018)]
    [Attributes(9)]
    public sealed class Wcdma1500Rel6TxMprBackoff
    {
        [FieldCount(7)]
        public byte[] Value { get; set; }
    }
}
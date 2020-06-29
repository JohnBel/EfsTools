using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7017)]
    [Attributes(9)]
    public sealed class Wcdma1500Rel6TxAgcOffset
    {
        [FieldCount(7)]
        public byte[] Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6966)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLinMaster3
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}
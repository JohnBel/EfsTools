using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7024)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLinMaster0Enh
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
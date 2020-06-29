using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6938)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLinMaster0
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}
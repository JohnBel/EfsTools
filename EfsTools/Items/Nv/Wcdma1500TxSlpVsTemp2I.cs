using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6971)]
    [Attributes(9)]
    public sealed class Wcdma1500TxSlpVsTemp2
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}
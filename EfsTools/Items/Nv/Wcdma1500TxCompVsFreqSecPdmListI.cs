using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7023)]
    [Attributes(9)]
    public sealed class Wcdma1500TxCompVsFreqSecPdmList
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}
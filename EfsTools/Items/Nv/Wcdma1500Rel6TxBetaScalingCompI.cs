using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7016)]
    [Attributes(9)]
    public sealed class Wcdma1500Rel6TxBetaScalingComp
    {
        [FieldCount(7)]
        public ushort[] Value { get; set; }
    }
}
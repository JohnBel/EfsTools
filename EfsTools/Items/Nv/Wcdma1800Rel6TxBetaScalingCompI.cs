using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5277)]
    [Attributes(9)]
    public sealed class Wcdma1800Rel6TxBetaScalingComp
    {
        [FieldCount(7)]
        public ushort[] Value { get; set; }
    }
}
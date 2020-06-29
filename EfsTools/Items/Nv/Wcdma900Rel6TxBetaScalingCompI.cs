using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5274)]
    [Attributes(9)]
    public sealed class Wcdma900Rel6TxBetaScalingComp
    {
        [FieldCount(7)]
        public ushort[] Value { get; set; }
    }
}
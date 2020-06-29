using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4950)]
    [Attributes(9)]
    public sealed class WcdmaBc4Rel6TxBetaScalingComp
    {
        [FieldCount(7)]
        public ushort[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4941)]
    [Attributes(9)]
    public sealed class WcdmaRel6TxBetaScalingComp
    {
        [FieldCount(7)]
        public ushort[] Value { get; set; }
    }
}
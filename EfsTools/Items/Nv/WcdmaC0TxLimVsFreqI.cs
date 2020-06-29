using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3341)]
    [Attributes(9)]
    public sealed class WcdmaC0TxLimVsFreq
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}
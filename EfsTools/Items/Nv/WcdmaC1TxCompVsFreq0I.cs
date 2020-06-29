using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2332)]
    [Attributes(9)]
    public sealed class WcdmaC1TxCompVsFreq0
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
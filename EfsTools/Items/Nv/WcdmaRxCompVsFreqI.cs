using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(515)]
    [Attributes(9)]
    public sealed class WcdmaRxCompVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4401)]
    [Attributes(9)]
    public sealed class WcdmaLnaOffsetVsFreq4
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
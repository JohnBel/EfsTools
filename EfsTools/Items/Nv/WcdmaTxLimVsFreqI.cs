using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(540)]
    [Attributes(9)]
    public sealed class WcdmaTxLimVsFreq
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}
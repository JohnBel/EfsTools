using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2712)]
    [Attributes(9)]
    public sealed class WcdmaMaxPwrBackoffVoltages
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}
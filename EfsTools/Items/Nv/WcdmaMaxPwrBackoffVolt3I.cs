using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2715)]
    [Attributes(9)]
    public sealed class WcdmaMaxPwrBackoffVolt3
    {
        [FieldCount(4)]
        public short[] Value { get; set; }
    }
}
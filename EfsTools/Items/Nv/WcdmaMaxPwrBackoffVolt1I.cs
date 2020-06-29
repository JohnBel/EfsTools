using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2713)]
    [Attributes(9)]
    public sealed class WcdmaMaxPwrBackoffVolt1
    {
        [FieldCount(4)]
        public short[] Value { get; set; }
    }
}
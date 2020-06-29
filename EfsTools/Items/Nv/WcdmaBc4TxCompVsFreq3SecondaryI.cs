using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4988)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxCompVsFreq3Secondary
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
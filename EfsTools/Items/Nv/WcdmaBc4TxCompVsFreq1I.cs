using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4028)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxCompVsFreq1
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4058)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxSlpVsTemp3
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
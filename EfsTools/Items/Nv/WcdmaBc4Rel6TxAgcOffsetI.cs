using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4951)]
    [Attributes(9)]
    public sealed class WcdmaBc4Rel6TxAgcOffset
    {
        [FieldCount(7)]
        public byte[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4049)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxCalChan
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}
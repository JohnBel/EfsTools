using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4952)]
    [Attributes(9)]
    public sealed class WcdmaBc4Rel6TxMprBackoff
    {
        [FieldCount(7)]
        public byte[] Value { get; set; }
    }
}
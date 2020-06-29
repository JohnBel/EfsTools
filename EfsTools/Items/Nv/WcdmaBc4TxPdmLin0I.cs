using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4112)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxPdmLin0
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
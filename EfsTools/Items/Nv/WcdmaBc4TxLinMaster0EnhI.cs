using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5056)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxLinMaster0Enh
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}
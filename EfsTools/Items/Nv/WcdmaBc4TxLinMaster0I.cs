using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4025)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxLinMaster0
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}
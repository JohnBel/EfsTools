using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4051)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxLinMaster2
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}
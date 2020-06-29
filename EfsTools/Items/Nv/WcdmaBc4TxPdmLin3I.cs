using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4115)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxPdmLin3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
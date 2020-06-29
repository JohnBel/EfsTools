using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4078)]
    [Attributes(9)]
    public sealed class WcdmaBc4UtranTxLimVsTempOffset
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}
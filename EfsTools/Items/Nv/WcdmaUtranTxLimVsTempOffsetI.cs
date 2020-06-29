using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2980)]
    [Attributes(9)]
    public sealed class WcdmaUtranTxLimVsTempOffset
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}
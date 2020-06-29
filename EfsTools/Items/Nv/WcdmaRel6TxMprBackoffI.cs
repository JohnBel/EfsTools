using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4943)]
    [Attributes(9)]
    public sealed class WcdmaRel6TxMprBackoff
    {
        [FieldCount(7)]
        public byte[] Value { get; set; }
    }
}
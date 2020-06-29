using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6756)]
    [Attributes(9)]
    public sealed class WcdmaRel7PaMprBackoff
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4956)]
    [Attributes(9)]
    public sealed class WcdmaLnaPhaseCtl
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
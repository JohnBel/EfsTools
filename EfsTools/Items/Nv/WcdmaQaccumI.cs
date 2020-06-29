using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4162)]
    [Attributes(9)]
    public sealed class WcdmaQaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
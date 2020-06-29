using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4161)]
    [Attributes(9)]
    public sealed class WcdmaIaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}
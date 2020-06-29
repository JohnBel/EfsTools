using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(875)]
    [Attributes(9)]
    public sealed class WcdmaTherm
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
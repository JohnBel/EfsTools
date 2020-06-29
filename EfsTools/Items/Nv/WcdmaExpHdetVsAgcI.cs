using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(542)]
    [Attributes(9)]
    public sealed class WcdmaExpHdetVsAgc
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}
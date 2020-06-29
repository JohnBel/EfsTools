using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3971)]
    [Attributes(9)]
    public sealed class WcdmaTxPdmLin2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}
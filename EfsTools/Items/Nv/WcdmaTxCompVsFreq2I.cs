using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2011)]
    [Attributes(9)]
    public sealed class WcdmaTxCompVsFreq2
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
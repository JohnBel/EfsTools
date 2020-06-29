using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(531)]
    [Attributes(9)]
    public sealed class WcdmaTxCompVsFreq0
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4967)]
    [Attributes(9)]
    public sealed class WcdmaTxCompVsFreq2Secondary
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
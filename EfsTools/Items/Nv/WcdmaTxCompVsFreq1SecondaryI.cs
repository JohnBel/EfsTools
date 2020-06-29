using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4966)]
    [Attributes(9)]
    public sealed class WcdmaTxCompVsFreq1Secondary
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
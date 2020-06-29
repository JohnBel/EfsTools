using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2334)]
    [Attributes(9)]
    public sealed class WcdmaTxLimVsVoltOffset
    {
        [FieldCount(3)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2014)]
    [Attributes(9)]
    public sealed class WcdmaTxLinVsTemp3
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
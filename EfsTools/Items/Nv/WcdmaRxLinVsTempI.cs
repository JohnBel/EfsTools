using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(516)]
    [Attributes(9)]
    public sealed class WcdmaRxLinVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
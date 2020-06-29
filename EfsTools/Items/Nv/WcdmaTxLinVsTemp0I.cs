using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(533)]
    [Attributes(9)]
    public sealed class WcdmaTxLinVsTemp0
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
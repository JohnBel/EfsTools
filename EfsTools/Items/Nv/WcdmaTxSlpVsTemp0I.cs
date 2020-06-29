using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(535)]
    [Attributes(9)]
    public sealed class WcdmaTxSlpVsTemp0
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(536)]
    [Attributes(9)]
    public sealed class WcdmaTxSlpVsTemp1
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
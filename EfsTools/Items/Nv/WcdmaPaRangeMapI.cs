using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2029)]
    [Attributes(9)]
    public sealed class WcdmaPaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1918)]
    [Attributes(9)]
    public sealed class AGpsDefaultQosTime
    {
        public uint Value { get; set; }
    }
}
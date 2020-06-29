using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3073)]
    [Attributes(9)]
    public sealed class DcsAntTimingRelToPaEnStop
    {
        public short Value { get; set; }
    }
}
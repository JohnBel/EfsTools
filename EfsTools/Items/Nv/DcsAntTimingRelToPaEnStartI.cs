using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3066)]
    [Attributes(9)]
    public sealed class DcsAntTimingRelToPaEnStart
    {
        public short Value { get; set; }
    }
}
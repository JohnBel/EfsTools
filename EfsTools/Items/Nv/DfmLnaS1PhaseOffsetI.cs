using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(618)]
    [Attributes(9)]
    public sealed class DfmLnaS1PhaseOffset
    {
        public ushort Value { get; set; }
    }
}
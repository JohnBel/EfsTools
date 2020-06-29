using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(617)]
    [Attributes(9)]
    public sealed class DfmLnaS0PhaseOffset
    {
        public ushort Value { get; set; }
    }
}
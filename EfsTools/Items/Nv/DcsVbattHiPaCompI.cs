using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(808)]
    [Attributes(9)]
    public sealed class DcsVbattHiPaComp
    {
        public byte Value { get; set; }
    }
}
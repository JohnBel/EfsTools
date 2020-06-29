using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(126)]
    [Attributes(9)]
    public sealed class FmFreqSenseGain
    {
        public byte Value { get; set; }
    }
}
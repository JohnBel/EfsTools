using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(611)]
    [Attributes(9)]
    public sealed class DfmAgcImGain
    {
        public byte Value { get; set; }
    }
}
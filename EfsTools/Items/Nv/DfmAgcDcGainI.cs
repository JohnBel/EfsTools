using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(612)]
    [Attributes(9)]
    public sealed class DfmAgcDcGain
    {
        public byte Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(608)]
    [Attributes(9)]
    public sealed class DfmLnaRise
    {
        public sbyte Value { get; set; }
    }
}
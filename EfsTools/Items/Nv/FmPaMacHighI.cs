using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(877)]
    [Attributes(9)]
    public sealed class FmPaMacHigh
    {
        public byte Value { get; set; }
    }
}
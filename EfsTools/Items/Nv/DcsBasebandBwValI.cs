using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2779)]
    [Attributes(9)]
    public sealed class DcsBasebandBwVal
    {
        public byte Value { get; set; }
    }
}
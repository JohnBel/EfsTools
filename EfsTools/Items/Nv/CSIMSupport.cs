using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6253)]
    [Attributes(9)]
    public sealed class CSimSupport
    {
        public byte Value { get; set; }
    }
}
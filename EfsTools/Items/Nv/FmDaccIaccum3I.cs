using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(657)]
    [Attributes(9)]
    public sealed class FmDaccIaccum3
    {
        public byte Value { get; set; }
    }
}
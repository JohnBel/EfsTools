using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(653)]
    [Attributes(9)]
    public sealed class FmDaccIaccum2
    {
        public byte Value { get; set; }
    }
}
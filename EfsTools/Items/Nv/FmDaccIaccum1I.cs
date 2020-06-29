using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(649)]
    [Attributes(9)]
    public sealed class FmDaccIaccum1
    {
        public byte Value { get; set; }
    }
}
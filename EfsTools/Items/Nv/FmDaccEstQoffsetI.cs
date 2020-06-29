using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(641)]
    [Attributes(9)]
    public sealed class FmDaccEstQoffset
    {
        public uint Value { get; set; }
    }
}
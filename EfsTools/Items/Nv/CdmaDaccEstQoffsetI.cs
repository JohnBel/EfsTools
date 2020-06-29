using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(639)]
    [Attributes(9)]
    public sealed class CdmaDaccEstQoffset
    {
        public uint Value { get; set; }
    }
}
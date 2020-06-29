using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1018)]
    [Attributes(9)]
    public sealed class CdmaReceiveDiversity
    {
        public ushort Value { get; set; }
    }
}
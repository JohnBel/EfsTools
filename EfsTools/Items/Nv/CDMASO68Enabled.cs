using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4102)]
    [Attributes(9)]
    public sealed class CdmaSO68Enabled
    {
        public byte Value { get; set; }
    }
}
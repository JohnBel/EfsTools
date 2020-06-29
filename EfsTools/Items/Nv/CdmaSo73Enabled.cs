using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7166)]
    [Attributes(9)]
    public sealed class CdmaSo73Enabled
    {
        public byte Value { get; set; }
    }
}
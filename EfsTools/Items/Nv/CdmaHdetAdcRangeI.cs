using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(312)]
    [Attributes(9)]
    public sealed class CdmaHdetAdcRange
    {
        public byte Value { get; set; }
    }
}
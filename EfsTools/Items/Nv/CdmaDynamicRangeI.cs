using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(878)]
    [Attributes(9)]
    public sealed class CdmaDynamicRange
    {
        public short Value { get; set; }
    }
}
using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(599)]
    [Attributes(9)]
    public sealed class CdmaLna4Offset
    {
        public short Value { get; set; }
    }
}
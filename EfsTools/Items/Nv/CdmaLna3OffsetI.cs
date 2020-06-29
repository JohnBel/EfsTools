using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(591)]
    [Attributes(9)]
    public sealed class CdmaLna3Offset
    {
        public short Value { get; set; }
    }
}
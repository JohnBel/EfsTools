using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(590)]
    [Attributes(9)]
    public sealed class CdmaLna3Fall
    {
        public sbyte Value { get; set; }
    }
}
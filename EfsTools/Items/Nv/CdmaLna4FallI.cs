using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(598)]
    [Attributes(9)]
    public sealed class CdmaLna4Fall
    {
        public sbyte Value { get; set; }
    }
}
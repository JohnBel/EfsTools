using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(600)]
    [Attributes(9)]
    public sealed class CdmaLna4Rise
    {
        public sbyte Value { get; set; }
    }
}
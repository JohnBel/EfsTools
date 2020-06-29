using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(814)]
    [Attributes(9)]
    public sealed class DcsPrecharge
    {
        public ushort Value { get; set; }
    }
}
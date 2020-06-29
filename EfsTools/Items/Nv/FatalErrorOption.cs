using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(905)]
    [Attributes(9)]
    public sealed class FatalErrorOption
    {
        public ushort Value { get; set; }
    }
}
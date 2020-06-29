using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5749)]
    [Attributes(9)]
    public sealed class Bc11HdetOffV2
    {
        public ushort Value { get; set; }
    }
}
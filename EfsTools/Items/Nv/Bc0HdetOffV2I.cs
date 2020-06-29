using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5738)]
    [Attributes(9)]
    public sealed class Bc0HdetOffV2
    {
        public ushort Value { get; set; }
    }
}
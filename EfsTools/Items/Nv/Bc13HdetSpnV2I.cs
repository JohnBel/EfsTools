using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5767)]
    [Attributes(9)]
    public sealed class Bc13HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}
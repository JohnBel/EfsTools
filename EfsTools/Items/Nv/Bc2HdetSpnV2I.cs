using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5756)]
    [Attributes(9)]
    public sealed class Bc2HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}
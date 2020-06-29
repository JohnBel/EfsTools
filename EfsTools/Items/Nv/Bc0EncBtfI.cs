using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1734)]
    [Attributes(9)]
    public sealed class Bc0EncBtf
    {
        public uint Value { get; set; }
    }
}
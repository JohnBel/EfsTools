using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1564)]
    [Attributes(9)]
    public sealed class Bc3HdetOff
    {
        public byte Value { get; set; }
    }
}
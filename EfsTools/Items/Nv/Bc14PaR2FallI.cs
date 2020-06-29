using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3550)]
    [Attributes(9)]
    public sealed class Bc14PaR2Fall
    {
        public byte Value { get; set; }
    }
}
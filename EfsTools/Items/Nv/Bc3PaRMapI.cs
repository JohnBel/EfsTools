using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4882)]
    [Attributes(9)]
    public sealed class Bc3PaRMap
    {
        public byte Value { get; set; }
    }
}
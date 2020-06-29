using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4887)]
    [Attributes(9)]
    public sealed class Bc14PaRMap
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4881)]
    [Attributes(9)]
    public sealed class Bc1PaRMap
    {
        public byte Value { get; set; }
    }
}
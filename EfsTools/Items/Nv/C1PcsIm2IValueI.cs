using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1023)]
    [Attributes(9)]
    public sealed class C1PcsIm2IValue
    {
        public byte Value { get; set; }
    }
}
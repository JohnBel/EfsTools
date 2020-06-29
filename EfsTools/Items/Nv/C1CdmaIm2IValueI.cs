using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1022)]
    [Attributes(9)]
    public sealed class C1CdmaIm2IValue
    {
        public byte Value { get; set; }
    }
}
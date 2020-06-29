using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3599)]
    [Attributes(9)]
    public sealed class C1Bc14Im2IValue
    {
        public byte Value { get; set; }
    }
}
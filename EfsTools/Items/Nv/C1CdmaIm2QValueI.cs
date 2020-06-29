using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1020)]
    [Attributes(9)]
    public sealed class C1CdmaIm2QValue
    {
        public byte Value { get; set; }
    }
}
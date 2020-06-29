using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1021)]
    [Attributes(9)]
    public sealed class C1PcsIm2QValue
    {
        public byte Value { get; set; }
    }
}
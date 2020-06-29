using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(983)]
    [Attributes(9)]
    public sealed class C1GpsMisCompBOffset
    {
        public int Value { get; set; }
    }
}
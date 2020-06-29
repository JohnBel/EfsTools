using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(981)]
    [Attributes(9)]
    public sealed class C1GpsMisCompAOffset
    {
        public int Value { get; set; }
    }
}
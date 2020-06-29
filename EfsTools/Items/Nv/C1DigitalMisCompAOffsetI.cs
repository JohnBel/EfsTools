using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(980)]
    [Attributes(9)]
    public sealed class C1DigitalMisCompAOffset
    {
        public int Value { get; set; }
    }
}
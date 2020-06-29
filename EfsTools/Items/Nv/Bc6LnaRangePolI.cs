using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1222)]
    [Attributes(9)]
    public sealed class Bc6LnaRangePol
    {
        public byte Value { get; set; }
    }
}
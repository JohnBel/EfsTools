using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4566)]
    [Attributes(9)]
    public sealed class BcxBlockPaR3Fall
    {
        public byte Value { get; set; }
    }
}
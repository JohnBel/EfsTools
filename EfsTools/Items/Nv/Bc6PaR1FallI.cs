using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1221)]
    [Attributes(9)]
    public sealed class Bc6PaR1Fall
    {
        public byte Value { get; set; }
    }
}
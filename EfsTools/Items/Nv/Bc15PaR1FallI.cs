using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4280)]
    [Attributes(9)]
    public sealed class Bc15PaR1Fall
    {
        public byte Value { get; set; }
    }
}
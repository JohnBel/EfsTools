using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5175)]
    [Attributes(9)]
    public sealed class Bc10PaR1Fall
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1402)]
    [Attributes(9)]
    public sealed class Bc5PaR1Fall
    {
        public byte Value { get; set; }
    }
}
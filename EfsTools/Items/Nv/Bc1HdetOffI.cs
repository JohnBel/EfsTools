using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1642)]
    [Attributes(9)]
    public sealed class Bc1HdetOff
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3553)]
    [Attributes(9)]
    public sealed class Bc14HdetOff
    {
        public byte Value { get; set; }
    }
}
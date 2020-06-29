using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4285)]
    [Attributes(9)]
    public sealed class Bc15HdetOff
    {
        public byte Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1731)]
    [Attributes(9)]
    public sealed class Bc0HdetOff
    {
        public byte Value { get; set; }
    }
}
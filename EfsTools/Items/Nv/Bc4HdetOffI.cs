using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1485)]
    [Attributes(9)]
    public sealed class Bc4HdetOff
    {
        public byte Value { get; set; }
    }
}
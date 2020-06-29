using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5180)]
    [Attributes(9)]
    public sealed class Bc10HdetOff
    {
        public byte Value { get; set; }
    }
}
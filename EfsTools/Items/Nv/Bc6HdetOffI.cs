using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1218)]
    [Attributes(9)]
    public sealed class Bc6HdetOff
    {
        public byte Value { get; set; }
    }
}
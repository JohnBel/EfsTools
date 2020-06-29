using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1407)]
    [Attributes(9)]
    public sealed class Bc5HdetOff
    {
        public byte Value { get; set; }
    }
}
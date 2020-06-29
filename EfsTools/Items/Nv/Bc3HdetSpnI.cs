using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1565)]
    [Attributes(9)]
    public sealed class Bc3HdetSpn
    {
        public byte Value { get; set; }
    }
}
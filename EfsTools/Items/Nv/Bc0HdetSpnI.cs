using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1732)]
    [Attributes(9)]
    public sealed class Bc0HdetSpn
    {
        public byte Value { get; set; }
    }
}
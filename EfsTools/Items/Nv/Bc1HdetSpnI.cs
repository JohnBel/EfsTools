using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1643)]
    [Attributes(9)]
    public sealed class Bc1HdetSpn
    {
        public byte Value { get; set; }
    }
}
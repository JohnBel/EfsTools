using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1645)]
    [Attributes(9)]
    public sealed class Bc1EncBtf
    {
        public uint Value { get; set; }
    }
}
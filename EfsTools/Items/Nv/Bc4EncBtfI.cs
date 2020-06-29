using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1488)]
    [Attributes(9)]
    public sealed class Bc4EncBtf
    {
        public uint Value { get; set; }
    }
}
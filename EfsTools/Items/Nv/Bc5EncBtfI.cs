using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1410)]
    [Attributes(9)]
    public sealed class Bc5EncBtf
    {
        public uint Value { get; set; }
    }
}
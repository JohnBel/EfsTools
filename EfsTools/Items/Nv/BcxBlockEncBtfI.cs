using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4570)]
    [Attributes(9)]
    public sealed class BcxBlockEncBtf
    {
        public uint Value { get; set; }
    }
}
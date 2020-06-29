using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4585)]
    [Attributes(9)]
    public sealed class C0BcxBlockVgaGainOffset
    {
        public short Value { get; set; }
    }
}
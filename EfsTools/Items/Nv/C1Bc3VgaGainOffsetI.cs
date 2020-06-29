using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1609)]
    [Attributes(9)]
    public sealed class C1Bc3VgaGainOffset
    {
        public short Value { get; set; }
    }
}
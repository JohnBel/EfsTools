using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1530)]
    [Attributes(9)]
    public sealed class C1Bc4VgaGainOffset
    {
        public short Value { get; set; }
    }
}
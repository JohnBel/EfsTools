using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(952)]
    [Attributes(9)]
    public sealed class C1CdmaLna2Offset
    {
        public short Value { get; set; }
    }
}
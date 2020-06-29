using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4607)]
    [Attributes(9)]
    public sealed class C1BcxBlockLna2Offset
    {
        public short Value { get; set; }
    }
}
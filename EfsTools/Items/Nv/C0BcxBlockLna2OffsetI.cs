using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4580)]
    [Attributes(9)]
    public sealed class C0BcxBlockLna2Offset
    {
        public short Value { get; set; }
    }
}
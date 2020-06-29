using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4608)]
    [Attributes(9)]
    public sealed class C1BcxBlockLna3Offset
    {
        public short Value { get; set; }
    }
}
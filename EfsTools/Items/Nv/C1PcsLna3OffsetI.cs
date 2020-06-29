using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(958)]
    [Attributes(9)]
    public sealed class C1PcsLna3Offset
    {
        public short Value { get; set; }
    }
}
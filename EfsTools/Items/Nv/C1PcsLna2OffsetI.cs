using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(954)]
    [Attributes(9)]
    public sealed class C1PcsLna2Offset
    {
        public short Value { get; set; }
    }
}
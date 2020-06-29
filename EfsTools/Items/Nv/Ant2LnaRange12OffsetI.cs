using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(502)]
    [Attributes(9)]
    public sealed class Ant2LnaRange12Offset
    {
        public short Value { get; set; }
    }
}
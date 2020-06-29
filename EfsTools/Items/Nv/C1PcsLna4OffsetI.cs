using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(962)]
    [Attributes(9)]
    public sealed class C1PcsLna4Offset
    {
        public short Value { get; set; }
    }
}
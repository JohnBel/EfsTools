using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(960)]
    [Attributes(9)]
    public sealed class C1CdmaLna4Offset
    {
        public short Value { get; set; }
    }
}
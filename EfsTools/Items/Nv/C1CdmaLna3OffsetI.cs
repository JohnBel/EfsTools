using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(956)]
    [Attributes(9)]
    public sealed class C1CdmaLna3Offset
    {
        public short Value { get; set; }
    }
}
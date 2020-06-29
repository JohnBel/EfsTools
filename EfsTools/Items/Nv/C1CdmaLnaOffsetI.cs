using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(948)]
    [Attributes(9)]
    public sealed class C1CdmaLnaOffset
    {
        public short Value { get; set; }
    }
}
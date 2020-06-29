using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1041)]
    [Attributes(9)]
    public sealed class C1CdmaLna1Fall
    {
        public sbyte Value { get; set; }
    }
}
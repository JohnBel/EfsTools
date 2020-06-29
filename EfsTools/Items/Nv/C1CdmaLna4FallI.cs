using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1044)]
    [Attributes(9)]
    public sealed class C1CdmaLna4Fall
    {
        public sbyte Value { get; set; }
    }
}
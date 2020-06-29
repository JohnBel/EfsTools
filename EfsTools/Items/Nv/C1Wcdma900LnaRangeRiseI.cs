using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4466)]
    [Attributes(9)]
    public sealed class C1Wcdma900LnaRangeRise
    {
        public short Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4471)]
    [Attributes(9)]
    public sealed class C1Wcdma900LnaRangeFall2
    {
        public short Value { get; set; }
    }
}
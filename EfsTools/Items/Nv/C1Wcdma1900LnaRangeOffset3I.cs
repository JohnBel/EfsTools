using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3805)]
    [Attributes(9)]
    public sealed class C1Wcdma1900LnaRangeOffset3
    {
        public short Value { get; set; }
    }
}
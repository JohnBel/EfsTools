using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1699)]
    [Attributes(9)]
    public sealed class C1Bc1VgaGainOffsetVsFreq
    {
        public sbyte[] Value { get; set; }
    }
}
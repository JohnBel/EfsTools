using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(979)]
    [Attributes(9)]
    public sealed class C1PcsVgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}
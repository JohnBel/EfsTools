using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3791)]
    [Attributes(9)]
    public sealed class C1Wcdma1900VgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
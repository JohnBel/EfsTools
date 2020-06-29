using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3821)]
    [Attributes(9)]
    public sealed class C1Wcdma800VgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7087)]
    [Attributes(9)]
    public sealed class C1Wcdma1500LnaOffsetVsFreq4
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}
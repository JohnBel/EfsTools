using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1265)]
    [Attributes(9)]
    public sealed class C1Bc6P1RiseFallOffset
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}
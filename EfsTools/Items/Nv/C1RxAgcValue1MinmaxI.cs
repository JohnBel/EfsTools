using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(966)]
    [Attributes(9)]
    public sealed class C1RxAgcValue1Minmax
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
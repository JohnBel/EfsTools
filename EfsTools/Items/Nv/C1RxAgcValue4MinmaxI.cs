using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(969)]
    [Attributes(9)]
    public sealed class C1RxAgcValue4Minmax
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
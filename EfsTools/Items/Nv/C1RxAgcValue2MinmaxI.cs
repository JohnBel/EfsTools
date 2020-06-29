using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(967)]
    [Attributes(9)]
    public sealed class C1RxAgcValue2Minmax
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}
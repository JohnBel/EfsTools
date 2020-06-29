using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1518)]
    [Attributes(9)]
    public sealed class C1Bc4TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
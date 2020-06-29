using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4601)]
    [Attributes(9)]
    public sealed class C1BcxBlockRxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
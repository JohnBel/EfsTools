using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1685)]
    [Attributes(9)]
    public sealed class C1Bc1TxCalChan
    {
        public ushort[] Value { get; set; }
    }
}
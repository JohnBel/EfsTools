using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4321)]
    [Attributes(9)]
    public sealed class C1Bc15TxCalChan
    {
        public ushort[] Value { get; set; }
    }
}
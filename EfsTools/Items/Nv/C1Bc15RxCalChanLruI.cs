using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4357)]
    [Attributes(9)]
    public sealed class C1Bc15RxCalChanLru
    {
        public byte[] Value { get; set; }
    }
}
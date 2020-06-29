using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2794)]
    [Attributes(9)]
    public sealed class C1Bc1RxCalChanLru
    {
        public byte[] Value { get; set; }
    }
}
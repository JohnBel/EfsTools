using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2802)]
    [Attributes(9)]
    public sealed class C1Bc6RxCalChanLru
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}
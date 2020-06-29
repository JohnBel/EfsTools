using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4491)]
    [Attributes(9)]
    public sealed class C1Wcdma900RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
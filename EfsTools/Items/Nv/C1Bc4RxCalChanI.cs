using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1519)]
    [Attributes(9)]
    public sealed class C1Bc4RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
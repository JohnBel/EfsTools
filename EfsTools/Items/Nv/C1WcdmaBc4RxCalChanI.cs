using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4520)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}
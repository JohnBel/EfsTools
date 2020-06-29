using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4322)]
    [Attributes(9)]
    public sealed class C1Bc15RxCalChan
    {
        public ushort[] Value { get; set; }
    }
}
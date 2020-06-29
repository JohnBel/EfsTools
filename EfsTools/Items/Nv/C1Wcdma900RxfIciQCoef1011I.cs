using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6465)]
    [Attributes(9)]
    public sealed class C1Wcdma900RxfIciQCoef1011
    {
        public uint Value { get; set; }
    }
}
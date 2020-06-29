using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6468)]
    [Attributes(9)]
    public sealed class C1Wcdma900RxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}
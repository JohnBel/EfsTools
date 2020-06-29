using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5979)]
    [Attributes(9)]
    public sealed class C1Wcdma1900RxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}
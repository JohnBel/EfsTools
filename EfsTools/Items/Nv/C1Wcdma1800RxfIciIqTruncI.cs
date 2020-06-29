using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6427)]
    [Attributes(9)]
    public sealed class C1Wcdma1800RxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}
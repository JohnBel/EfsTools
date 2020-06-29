using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6047)]
    [Attributes(9)]
    public sealed class C1Wcdma800RxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}
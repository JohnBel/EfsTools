using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6032)]
    [Attributes(9)]
    public sealed class C1Wcdma800RxfIciICoef45
    {
        public uint Value { get; set; }
    }
}
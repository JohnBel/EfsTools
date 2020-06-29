using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5928)]
    [Attributes(9)]
    public sealed class C1Wcdma2100RxfIciICoef01
    {
        public uint Value { get; set; }
    }
}
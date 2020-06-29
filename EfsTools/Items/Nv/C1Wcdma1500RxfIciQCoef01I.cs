using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7108)]
    [Attributes(9)]
    public sealed class C1Wcdma1500RxfIciQCoef01
    {
        public uint Value { get; set; }
    }
}
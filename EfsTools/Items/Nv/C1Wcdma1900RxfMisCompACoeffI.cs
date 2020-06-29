using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5902)]
    [Attributes(9)]
    public sealed class C1Wcdma1900RxfMisCompACoeff
    {
        public short Value { get; set; }
    }
}
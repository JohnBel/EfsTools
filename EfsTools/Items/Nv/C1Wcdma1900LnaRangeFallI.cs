using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3796)]
    [Attributes(9)]
    public sealed class C1Wcdma1900LnaRangeFall
    {
        public short Value { get; set; }
    }
}
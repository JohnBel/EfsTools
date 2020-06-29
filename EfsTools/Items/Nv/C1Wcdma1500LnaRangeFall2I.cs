using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7075)]
    [Attributes(9)]
    public sealed class C1Wcdma1500LnaRangeFall2
    {
        public short Value { get; set; }
    }
}
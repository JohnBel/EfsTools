using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7077)]
    [Attributes(9)]
    public sealed class C1Wcdma1500LnaRangeFall4
    {
        public short Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4460)]
    [Attributes(9)]
    public sealed class C1Wcdma1800LnaRangeOffset
    {
        public short Value { get; set; }
    }
}
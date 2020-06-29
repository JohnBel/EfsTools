using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4437)]
    [Attributes(9)]
    public sealed class C1Wcdma1800LnaRangeRise
    {
        public short Value { get; set; }
    }
}
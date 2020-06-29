using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7071)]
    [Attributes(9)]
    public sealed class C1Wcdma1500LnaRangeRise2
    {
        public short Value { get; set; }
    }
}
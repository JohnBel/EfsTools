using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1452)]
    [Attributes(9)]
    public sealed class C1Bc5VgaGainOffset
    {
        public short Value { get; set; }
    }
}
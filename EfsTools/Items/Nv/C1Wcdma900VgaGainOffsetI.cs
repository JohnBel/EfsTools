using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4463)]
    [Attributes(9)]
    public sealed class C1Wcdma900VgaGainOffset
    {
        public short Value { get; set; }
    }
}
using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1025)]
    [Attributes(9)]
    public sealed class C1PcsIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
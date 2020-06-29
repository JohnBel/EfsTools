using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4614)]
    [Attributes(9)]
    public sealed class C1BcxBlockIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
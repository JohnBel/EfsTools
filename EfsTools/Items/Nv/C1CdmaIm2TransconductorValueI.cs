using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1024)]
    [Attributes(9)]
    public sealed class C1CdmaIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
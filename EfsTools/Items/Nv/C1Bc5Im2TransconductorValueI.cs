using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1454)]
    [Attributes(9)]
    public sealed class C1Bc5Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
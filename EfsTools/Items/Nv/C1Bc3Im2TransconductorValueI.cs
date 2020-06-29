using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1611)]
    [Attributes(9)]
    public sealed class C1Bc3Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
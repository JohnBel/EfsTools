using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3786)]
    [Attributes(9)]
    public sealed class C1Wcdma2100Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
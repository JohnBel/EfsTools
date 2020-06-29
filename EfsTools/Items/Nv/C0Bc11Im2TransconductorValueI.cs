using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3890)]
    [Attributes(9)]
    public sealed class C0Bc11Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
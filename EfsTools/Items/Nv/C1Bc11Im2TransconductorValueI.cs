using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3917)]
    [Attributes(9)]
    public sealed class C1Bc11Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
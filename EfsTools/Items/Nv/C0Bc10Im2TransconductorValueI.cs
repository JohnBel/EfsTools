using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5222)]
    [Attributes(9)]
    public sealed class C0Bc10Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
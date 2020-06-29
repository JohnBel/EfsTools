using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6119)]
    [Attributes(9)]
    public sealed class C1BcxBlock1Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}
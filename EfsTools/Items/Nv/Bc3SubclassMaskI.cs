using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6222)]
    [Attributes(9)]
    public sealed class Bc3SubclassMask
    {
        public uint Value { get; set; }
    }
}
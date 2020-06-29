using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6224)]
    [Attributes(9)]
    public sealed class Bc5SubclassMask
    {
        public uint Value { get; set; }
    }
}
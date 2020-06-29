using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6227)]
    [Attributes(9)]
    public sealed class Bc8SubclassMask
    {
        public uint Value { get; set; }
    }
}
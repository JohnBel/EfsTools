using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6210)]
    [Attributes(9)]
    public sealed class BcxBlockSubclassMask
    {
        public uint Value { get; set; }
    }
}